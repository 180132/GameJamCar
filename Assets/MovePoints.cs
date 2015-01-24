using UnityEngine;
using System.Collections;

public class MovePoints : MonoBehaviour {
	public delegate void handler();
	public static event handler collision;

	public GameObject waypointA;
	public GameObject waypointB;
	public GameObject waypointC;
	public float speed = 1;
	private bool directionAB = true;
	private GameObject destination;
	public float distance = 30;
	// Use this for initialization
	void Start () {
		destination = waypointB;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 p = this.transform.position;
		if(p == waypointA.transform.position && directionAB == false ||
		   p == destination.transform.position && directionAB == true)
		{
			if(p == destination.transform.position)
			{

				changeDir();
				if(collision!= null)
					collision();
			}
		}
		if (distanceCheck() == false)
			Debug.Log("w zaSIEGU");

			this.transform.position = Vector3.MoveTowards (this.transform.position, 
			                                              destination.transform.position,
		                                              speed * Time.fixedDeltaTime);
	}


	void changeDir() {
		if(destination.transform.position == waypointB.transform.position)
			destination = waypointC;
		else
			if (destination.transform.position == waypointC.transform.position)
				destination = waypointA;
			else
				if (destination.transform.position == waypointA.transform.position)
					destination = waypointB;
	}


	bool distanceCheck() {
		float xLeng, yLeng;
		xLeng = Mathf.Abs (this.transform.position.x - destination.transform.position.x);
		yLeng = Mathf.Abs (this.transform.position.y - destination.transform.position.y);
		//Debug.Log (Mathf.Sqrt((xLeng*xLeng) + (yLeng*yLeng)));
		//Debug.Log (distance);
		if(distance < Mathf.Sqrt((xLeng*xLeng) + (yLeng*yLeng)))
			return true;
		else
			return false;
	}

}
