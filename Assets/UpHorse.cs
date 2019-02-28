using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpHorse : MonoBehaviour {

	public GameObject hero;
	public float horseHeight;

	// Use this for initialization
	void Start () {
		horseHeight = transform.position.y;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hero.transform.position.y > 24) {
			moving ();
		}
	}

	public void moving (){
		if (transform.position.y < 0.5) {
			horseHeight = horseHeight + 0.1f;
			transform.position = new Vector3 (transform.position.x, horseHeight, transform.position.z);
		}
	}
}
