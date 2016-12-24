using UnityEngine;
using System.Collections;

public class StarScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        GameScript.starsInGame++;
        print(GameScript.starsInGame);
        Destroy(this.gameObject);
    }

}
