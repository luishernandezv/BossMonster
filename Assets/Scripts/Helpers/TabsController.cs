using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabsController : MonoBehaviour {

	TabController[] tabs;
	
	[SerializeField] TabController defaultActiveTab;
	TabController currentActiveTab;
	HashSet<string> tabNames = new HashSet<string>();

	void Awake(){
		
		tabs = GetComponentsInChildren<TabController>(true);

		for(int i = 0; i < tabs.Length; i++)
		{
			bool unique = tabNames.Add(tabs[i].TabName);

			if(!unique){
				Debug.LogError("The name for this tab is not unique");
			}
		}

		Debug.Log(tabs.Length);
		
		SetActiveTabByReference(defaultActiveTab);
	}

	public void SetActiveTabByName(string name){
		for(int i = 0; i < tabs.Length; i++)
		{
			if(string.Compare(tabs[i].TabName, name) == 0) EnableTab(tabs[i]);
			else Disable(tabs[i]);
		}
	}

	public void SetActiveTabByIndex(int index){
		for(int i = 0; i < tabs.Length; i++)
		{
			if(i == index) EnableTab(tabs[i]);
			else Disable(tabs[i]);
		}
	}

	public void SetActiveTabByReference(TabController tab){
		for(int i = 0; i < tabs.Length; i++)
		{
			if(tabs[i] == tab) EnableTab(tabs[i]);
			else Disable(tabs[i]);
		}
	}

	private void EnableTab(TabController tab){
		tab.Enable();
		currentActiveTab = tab;
	}

	private void Disable(TabController tab){
		tab.Disable();
	}
}
