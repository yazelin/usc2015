using UnityEngine;
using System.Collections;

public class URLButtonScript : MonoBehaviour {

	//私有宣告 遊戲物件，按鈕
	private GameObject button;
	
	// Use this for initialization
	//這區程式碼只有在一開始的時候會執行一次
	void Start () {
		//從目前場景內找一個名稱為"This_is_a_Button"的遊戲物件
		button = GameObject.Find ("This_is_a_URL_Button");
		//在這個遊戲物件被點擊的時候，做"buttonClick"的動作
		UIEventListener.Get(button).onClick = buttonClick;
		
	}
	
	// Update is called once per frame
	//這區塊的程式碼會一直一直重覆的執行，直到離開程式碼存在的場景
	void Update () {
		//沒什麼要做的事
	}
	
	//按鈕被點擊到的時候要做的事
	void buttonClick(GameObject button){
		//打開這個URL:http://yazelin.github.io/usc2015/week2.html
		Application.OpenURL ("http://yazelin.github.io/usc2015/week2.html");
	}
}
