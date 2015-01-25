using UnityEngine;
using System.Collections;

public class MovePoints : MonoBehaviour {
	public delegate void handler();
	public static event handler collision;
	public static bool ruch;
	public GameObject waypointA;
	public GameObject waypointB;
	public GameObject waypointC;
	public GameObject waypointD;
	public GameObject waypointE;
	public GameObject waypointF;
	public GameObject waypointG;
	public GameObject waypointH;
	public GameObject waypointI;
	public GameObject waypointJ;
	public GameObject waypointK;
	public GameObject waypointL;
	public GameObject waypointM;

	private Vector2 vectorRuchu;
	private Vector2 vectorPoprzedni;
	public float speed = 1;
	private bool beginning;
	private GameObject destination;
	public float distance = 30;
	// Use this for initialization
	void Start () {
		destination = waypointA;
		ruch = true;
		beginning = true;
		vectorPoprzedni = new Vector2 (0, 1);
		calculateVRuchu ();
		//Debug.Log (destination.transform.position.x);
		//Debug.Log (destination.transform.position.y);
		//Debug.Log (this.transform.position.x);
		//Debug.Log (this.transform.position.y);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 p = this.transform.position;
		if(p == destination.transform.position)
		{
			if(p == destination.transform.position && ruch == true)
			{
				ruch = false;
				changeDir();
				if(collision!= null){
					collision();
					beginning = true;
				}
				//beginning = true;
			}
		}
		if (distanceCheck() == false)
			Debug.Log("w zaSIEGU");
		if (beginning == true && ruch == true) {
			Debug.Log("rotacja");
			this.transform.Rotate(Vector3.forward, Vector2.Angle(vectorPoprzedni, vectorRuchu));

		}
		if (ruch)
						//this.transform.Rotate (0, 0, 10);
			this.transform.position = Vector3.MoveTowards (this.transform.position, 
			                                              destination.transform.position,
		                                              speed * Time.fixedDeltaTime);
		//if (p == destination.transform.position) {
		//	Debug.Log ("zmiana beginning");
		//	beginning = true;
		//}
		//else
			beginning = false;
	}


	void changeDir() {
		if (destination.transform.position == waypointA.transform.position) {
			ConsoleScript.scen = 0;
						destination = waypointB;
				} else
			if (destination.transform.position == waypointB.transform.position) {
			ConsoleScript.scen = 1;
						destination = waypointC;
				} else
				if (destination.transform.position == waypointC.transform.position) {
			ConsoleScript.scen = 2;
						destination = waypointD;
				} else
					if (destination.transform.position == waypointD.transform.position) {
			ConsoleScript.scen = 3;
						destination = waypointE;
				} else
						if (destination.transform.position == waypointE.transform.position) {
			ConsoleScript.scen = 4;
						destination = waypointF;
				} else
							if (destination.transform.position == waypointF.transform.position) {
			ConsoleScript.scen = 5;
						destination = waypointG;
				} else
								if (destination.transform.position == waypointG.transform.position) {
			ConsoleScript.scen = 6;
						destination = waypointH;
				} else
									if (destination.transform.position == waypointH.transform.position) {
			ConsoleScript.scen = 7;
						destination = waypointI;
				} else
										if (destination.transform.position == waypointI.transform.position) {
			ConsoleScript.scen = 8;
						destination = waypointJ;
				} else 
											if (destination.transform.position == waypointJ.transform.position) {
			ConsoleScript.scen = 9;
						destination = waypointK;
				} else
												if (destination.transform.position == waypointK.transform.position) {
			ConsoleScript.scen = 10;
						destination = waypointL;
				} else
													if (destination.transform.position == waypointL.transform.position) {
			ConsoleScript.scen = 11;
						destination = waypointM;
				} else
														if (destination.transform.position == waypointM.transform.position) {
			ConsoleScript.scen = 12;
				}
											
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
	void calculateVRuchu()
	{
		vectorRuchu = new Vector2 (destination.transform.position.x - this.transform.position.x, destination.transform.position.y - this.transform.position.y);
	}

}
