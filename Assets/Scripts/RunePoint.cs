using UnityEngine;
using System.Collections;

public class RunePoint : MonoBehaviour {
	public Material upMat;
	public Material downMat;
	
	public bool isActive{get;set;}
	
	MeshRenderer runeRenderer;
	
	void Awake(){
		runeRenderer = GetComponent<MeshRenderer>();
		Reset();
	}
	
	void OnMouseDown(){
		if(!isActive){
			isActive = true;
			runeRenderer.sharedMaterial = downMat;
		}
		else{
			isActive = false;
			runeRenderer.sharedMaterial = upMat;
		}
		
		World.instance.master.runeCode.text = World.instance.master.GetRuneCode();
	}
	
	void Reset(){
		isActive = false;
		runeRenderer.sharedMaterial = upMat;
	}
}
