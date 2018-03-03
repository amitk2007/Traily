using UnityEngine;
using System.Collections;

public class NewPlayerScript : MonoBehaviour 
{
    #region variables
    bool moved = false;
	public static float startTime=0;
    Vector3 lastTouch = Vector3.zero;
    #endregion

    void Start () {
	}
	
	void Update () 
	{
		if (Input.touchCount!=0) 
		{
			if (startTime == 0) {
				startTime = Time.time;
				Debug.Log(Time.time);
			}
			this.transform.position = PointsToVector3(Input.touches[0].position.x,Input.touches[0].position.y,10);
			moved = true;
            this.transform.LookAt(lastTouch);
            lastTouch = this.transform.position;
        }
		if (Input.touchCount == 0) 
		{
			if (moved==true) {
			}
		}
		
	}

    Vector3 PointsToVector3(float x,float y, float z)
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(x,y,z));
    }

}
