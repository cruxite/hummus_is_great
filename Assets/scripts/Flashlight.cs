using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

	public Light light;
	void Start () {
        	Debug.Log(light.name);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("flashlight_toggle_l") || Input.GetButtonDown("flashlight_toggle_r") || Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Ding motherfucker");
            light.enabled = !light.enabled;
        }
	}
}