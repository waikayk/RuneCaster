using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject board;
	public Text runeCode;
	
	Dictionary<string, RunePoint> runeGrid;
	
	public void Awake(){
		World.instance.master = this;
		
		runeGrid = new Dictionary<string, RunePoint>();
		foreach(Transform child in board.transform){
			runeGrid.Add(child.name, child.GetComponent<RunePoint>());
		}
	}
	
	public string GetRuneCode(){
		string runeCode = "";
		for(int i = 0; i < runeGrid.Count; i++){
			runeCode += (runeGrid[i.ToString()].isActive ? "1" : "0");
		}
		return runeCode;
	}
}
