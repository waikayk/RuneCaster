using UnityEngine;
using System.Collections;

public class World {
	private static World instanceInternal;
	public static World instance {
		get{
			if (instanceInternal == null){
				new World();
			}
			return instanceInternal;
		}
	}
	
	public World(){
		if (instanceInternal != null){
			Debug.Log ("Cannot have two instances of singleton. Ignoring...");
			return;
		}
		instanceInternal = this;
		Initialize();
	}
	
	public GameController master;
	
	void Initialize(){
		
	}
}
