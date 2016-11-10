using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public GameObject player;
	public GUISkin theSkin;
	public static float scoreTime=0;
	// Use this for initialization
	void Start () {
        AdManager.Instance.ShowBanner();
	}
	
	// Update is called once per frame
	void Update () {
		if (player == null) {
            AdManager.Instance.ShowVideo();
			Application.LoadLevel("EndGAme 1");
		} else {
			if (PlayerScript.startTime!=0) {
				scoreTime = Time.time - PlayerScript.startTime;
			}
		}
	}

	void OnGUI () 
	{
		GUI.skin = theSkin;
		theSkin.label.fontSize =  Screen.height/25;
		GUI.Label (new Rect (Screen.width/10, 25, Screen.width/3, Screen.height/5), ""+(scoreTime));
	}
}
