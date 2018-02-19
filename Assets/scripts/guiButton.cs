using System;
using UnityEngine;
using System.Collections;



public class guiButton : MasterClass
	{
	//create boolean operation to reset button 
	public bool debugMode = false;

	//create texture for class button 
	public Texture buttonTex;
	//rectangle on the screen to use for the button, but need mesh renderer to substitiute cylinder instead of rectangle
	void onGUI()
	{
		if(!buttonTex)
		{
			Debug.LogError ("Please assign a texture on the inspector");
			return;
			//returns bool true when the button is clicked
		}

		if(GUI.Button(new Rect(10, 10, 50, 50), buttonTex)){
			Debug.Log ("Click the button with the image");

			if (GUI.Button (new Rect (10, 70, 50, 30), "Click"))
				Debug.Log ("click the button with the text");
		}
			
	}
		
}
