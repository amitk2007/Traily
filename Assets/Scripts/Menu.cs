using UnityEngine;
using System.Collections;
//
using UnityEngine.UI;
//

public class Menu : MonoBehaviour {
	
	public GameObject PointsText;
	// Use this for initialization
	void Start () {
		PointsText.GetComponent<Text> ().text = GameScript.scoreTime.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ButtonMainMenu()
	{
		Application.LoadLevel ("menu");
	}

	public void PlayGame()//ButtonTryAgain + ButtonStartGame
	{
		//****playerScript.playerScore = 0;
		Application.LoadLevel("MainGame");
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
