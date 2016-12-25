using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHightScore : MonoBehaviour
{

   // float highScore;
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

        /*highScore = Holders.highscore;

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
        HighPointsText.GetComponent<Text>().text = highScore.ToString();*/

        if (Holders.highscore < score)
        {
            NewBest.GetComponent<Text>().enabled = true;
        }
        else
        {
            NewBest.GetComponent<Text>().enabled = false;
        }

        Holders.highscore = Mathf.Max(Holders.highscore, score);
        Holders.SaveFloat("highscore", Holders.highscore);
        HighPointsText.GetComponent<Text>().text = Holders.highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
