using UnityEngine;
using System.Collections;

public class URLButtonScript : MonoBehaviour {

	
	private GameObject button;
	
	// Use this for initialization
	void Start () {
		button = GameObject.Find ("This_is_a_URL_Button");
		UIEventListener.Get(button).onClick = buttonClick;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void buttonClick(GameObject button){
		Application.OpenURL ("http://yazelin.github.io/usc2015/week2.html");
	}
}
