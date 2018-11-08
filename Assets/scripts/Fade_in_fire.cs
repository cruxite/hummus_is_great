using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_in_fire : MonoBehaviour {

	public Light fire;
	void Start () {
		fire = GetComponent<Light>();
		fire.intensity = 0.2F;
		if(!enabled){
			enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		while(fire.intensity < 1.3) {
			fire.intensity += 0.1F;
		}
	}
}
