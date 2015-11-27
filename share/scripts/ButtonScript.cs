using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	private GameObject button;

	// Use this for initialization
	void Start () {
		button = GameObject.Find ("This_is_a_Button");
		UIEventListener.Get(button).onClick = buttonClick;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void buttonClick(GameObject button){
		Application.LoadLevel ("AR");
	}
}
