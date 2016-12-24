using UnityEngine;
using System.Collections;

public class Holders : MonoBehaviour {

    public static int Coins;
    public static float highscore;
    // Use this for initialization
    void Start () {
        Coins = GetInt("Coins", 0);
        highscore = GetFloat("highscore",0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    #region Get (Int/Float/String)
    public static float GetFloat(string name, float defaultVlaue)
    {
        return PlayerPrefs.GetFloat(name, defaultVlaue);
    }
    public static int GetInt(string name, int defaultVlaue)
    {
        return PlayerPrefs.GetInt(name, defaultVlaue);
    }
    public static string GetString(string name, string defaultVlaue)
    {
        return PlayerPrefs.GetString(name, defaultVlaue);
    }
    #endregion

    #region Save/set (Int/Flaot/String)
    public static void SaveFloat(string name, float value)
    {
        PlayerPrefs.SetFloat(name, value);
    }
    public static void SaveInt(string name, int value)
    {
        PlayerPrefs.SetInt(name, value);
    }
    public static void SaveString(string name, string value)
    {
        PlayerPrefs.SetString(name, value);
    }
    #endregion
}
