using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkToHorse : MonoBehaviour {

	public GameObject hero;
	public Text horseSpeech;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hero.transform.position.y > 24){
			horseSpeech.text = "I've been expecting you. I am a horse and I am glad to see you. I am so proud. Thank you.";
		}
	}
}