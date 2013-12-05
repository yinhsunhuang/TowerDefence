﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    SystemMain systemMain;

	// Use this for initialization
	void Start () {
        systemMain = GetComponent<SystemMain>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.BeginGroup (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100));
		// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
		
		// We'll make a box so you can see where the group is on-screen.
		//GUI.Box (new Rect (0, 0, 100, 100), "Single Player");
		//GUI.Button (new Rect (10, 40, 80, 30), "Save");
		if(GUI.Button (new Rect (10, 40, 80, 30), "Single Player")){
			Application.LoadLevel("scene");
		}
		
		// End the group we started above. This is very important to remember!
		GUI.EndGroup ();
	}



    protected void EnterSingleGame()
    {
        
    }

    protected void EnterMultiGame()
    {

    }

    protected void EnterSettings()
    {

    }

    protected void EntetAbout()
    {

    }

}
