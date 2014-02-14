using UnityEngine;
using System;


public class keyPress : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("Jump"))
			Debug.Log("We have hit the Space Bar!");
	
	}
}
