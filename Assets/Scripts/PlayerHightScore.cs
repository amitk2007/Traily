using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHightScore : MonoBehaviour
{

    float highScore;
    float score;
    public GameObject HighPointsText;
    public GameObject NewBest;
    // Use this for initialization
    void Start()
    {
        score = GameScript.scoreTime;
        PlayerScript.startTime = 0;
        GameScript.scoreTime = 0;
        //score = playerScript.playerScore;

        highScore = Holders.highscore;

        if (highScore < score)
        {
            NewBest.GetComponent<Text>().enabled = true;
        }
        else
        {
            NewBest.GetComponent<Text>().enabled = false;
        }

        highScore = Mathf.Max(highScore, score);
        Holders.SaveFloat("highscore", highScore);
        HighPointsText.GetComponent<Text>().text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
