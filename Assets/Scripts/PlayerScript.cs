using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{

	bool moved = false;
	public static float startTime=0;
	void Start () {
	}
	
	void Update () 
	{
		if (Input.touchCount!=0) 
		{
			if (startTime == 0) {
				startTime = Time.time;
				Debug.Log(Time.time);
			}
			this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x,Input.touches[0].position.y,10));
			moved = true;
		}
		if (Input.touchCount == 0) 
		{
			if (moved==true) {
			}
		}
		
	}
}
