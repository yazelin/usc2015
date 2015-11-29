using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour {
	private float lastTouchBegan = 0.0f;//用來暫時記錄手指按下瞬間的時間
	// Use this for initialization
	//這區程式碼只有在一開始的時候會執行一次
	void Start () {
	
	}
	
	// Update is called once per frame 
	//這區塊的程式碼會一直一直重覆的執行，直到離開程式碼存在的場景
	void Update () 
	{
		//Detect tap to trigger refocus
		if (Input.touchCount == 1) //如果按下的只有一隻手指頭
		{
			TouchPhase phase = Input.GetTouch (0).phase;//取得手指touch的資訊

			if (phase == TouchPhase.Began) //如果狀態是手指按下去開始touch的動作(began)
			{
				lastTouchBegan = Time.time;//記錄按下去的時間點
			}
			else if (phase == TouchPhase.Ended) //如果狀態是手指拿起來結束touch的動作(ended)
			{
				//手指拿起來的時間-按下的時間，如果很快(<0.15秒), 就當作它是輕點(tap)
				if (Time.time - lastTouchBegan <= 0.15f) 
				{
					//Vuforia設定相機對焦的模式 為 觸發自動對焦
					Vuforia.CameraDevice.Instance.SetFocusMode (Vuforia.CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
				}
			}
		}
		
	}
}
