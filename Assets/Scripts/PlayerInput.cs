using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	static int dialogMenu = 0;

	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
		// DIALOG CONTROLS
		if (Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.K)) { 	// XBOX GAMEPAD: A --> ACTION BUTTON
			if (dialogMenu != 0) {
				dialogMenu = 0; // Cancel Dialog Menu
			}
			else {
				// PERFORM AN ACTION (Pick up something, open a door, put down an object, fart loudly, etc)
			}
			print (dialogMenu);
		}
		if (Input.GetKeyDown(KeyCode.JoystickButton2) || Input.GetKeyDown(KeyCode.J)) {		// XBOX GAMEPAD: X --> CONTEXT DIALOG
			if (dialogMenu == 0) {
				dialogMenu = 1; // Go to Context Dialog Menu
				// DO: DisplayDialogBoxes
			} else {
				// Choose Dialog Line at Position 1
			}
			print (dialogMenu);
		}
		if (Input.GetKeyDown(KeyCode.JoystickButton3) || Input.GetKeyDown(KeyCode.I)) { 	// XBOX GAMEPAD: B --> QUESTION DIALOG
			if (dialogMenu == 0) {
				dialogMenu = 2; // Go to Questions Dialog Menu
			} else {
				// Choose Dialog Line at Position 2
			}
			print (dialogMenu);
		}
		if (Input.GetKeyDown(KeyCode.JoystickButton1) || Input.GetKeyDown(KeyCode.L)) { 	// XBOX GAMEPAD: A --> ANSWER DIALOG
			if (dialogMenu == 0) {
				dialogMenu = 3; // Go to Answers Dialog Menu
			} else {
				// Choose Dialog Line at Position 3
			}
			print (dialogMenu);
		}
	}
}
