using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMenu : MonoBehaviour {

	[SerializeField]
	public TabsController tabController;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnHeroClick(){
		tabController.SetActiveTabByName("HeroMainTab");
	}

	public void OnDungeonClick(){
		tabController.SetActiveTabByName("DungeonMainTab");
	}
}
