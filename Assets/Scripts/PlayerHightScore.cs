using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHightScore : MonoBehaviour {

	public static float highscore;
	float score;
	public GameObject HighPointsText;
	public GameObject NewBest;
	// Use this for initialization
	void Start () {

		score = GameScript.scoreTime;
		PlayerScript.startTime = 0;
		GameScript.scoreTime = 0;
			//score = playerScript.playerScore;
		
		PlayerPrefs.SetFloat ("highscore", highscore);

		if (highscore < score) {
			NewBest.GetComponent<Text> ().enabled = true;
		} else {
			NewBest.GetComponent<Text>().enabled = false;
		}

		highscore = Mathf.Max(highscore,score);
		PlayerPrefs.SetFloat ("highscore",highscore);
		HighPointsText.GetComponent<Text> ().text = highscore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
