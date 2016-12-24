﻿using UnityEngine;
using System.Collections;
//
using UnityEngine.UI;
//

public class Menu : MonoBehaviour {
	
	public GameObject PointsText;
    public GameObject CoinsText;
	// Use this for initialization
	void Start () {
		PointsText.GetComponent<Text> ().text = GameScript.scoreTime.ToString();
        CoinsText.GetComponent<Text>().text = Holders.Coins.ToString();
        AdManager.Instance.RemoveBunner();
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
