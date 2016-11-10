using UnityEngine;
using System.Collections;

public class PreLoaderAnimation : MonoBehaviour
{

    public GameObject player;
    public GameObject text;
    public GameObject AdHelper;
    // Use this for initialization
    void Start()
    {
        AdHelper.GetComponent<AdManager>().enabled = true;

        Vector3 leftRightCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 10));
        player.transform.position = leftRightCorner;
        player.transform.GetComponent<Rigidbody>().AddForce(-leftRightCorner * 20);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > 1 && player.transform.position.y < -1)
        {
            text.gameObject.SetActive(true);
        }
        if (player.transform.position.x > 2 && player.transform.position.y < -2)
        {
            System.Threading.Thread.Sleep(1000);
            Application.LoadLevel("EndGame 1");
        }
    }
}
