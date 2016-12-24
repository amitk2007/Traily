using UnityEngine;
using System.Collections;

public class StrarsSpone : MonoBehaviour {

    // public GameObject star;
    public float time;
    public float addTime;
    public GameObject Star;
    public Camera cam;
	// Use this for initialization
	void Start () {
        time = 5;
        addTime = time;
    }

    // Update is called once per frame
    void Update () {
        Debug.Log(time.ToString());
        if (time < GameScript.scoreTime)
        {
            SpwanStar();
            addTime = addTime - 0.001f;
            time = time + addTime;
            print(time+"add"+addTime);
        }
    }

    void SpwanStar()
    {
        float x = Random.Range(0.0f, Screen.width);
        float y = Random.Range(0.0f, Screen.height);
        
        Instantiate(Star, cam.ScreenToWorldPoint(new Vector3(x,y,10)), Quaternion.identity);
    }
}
