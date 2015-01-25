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

	private int typSkr;
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
		typSkr = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		int i;
		float t = 45345;
		Vector3 p = this.transform.position;
		if(p == destination.transform.position)
		{
			if(p == destination.transform.position && ruch == true)
			{
				vectorPoprzedni = vectorRuchu;
				ruch = false;
				changeDir();
				if(collision!= null){
					collision();
					Debug.Log("wywolanie");
					beginning = true;
				}
				calculateVRuchu();
				//beginning = true;
			}
		}
		if (distanceCheck() == false)
			Debug.Log("w zaSIEGU");

		/*if (beginning == true && ruch == true) {
						Debug.Log ("rotacja" + Vector2.Angle (vectorPoprzedni, vectorRuchu));
	
						for (i=0; i<20; i++)
						{
							Debug.Log("TEStT");
							StartCoroutine(Delay());
							if (typSkr == 1) {
									this.transform.Rotate (Vector3.forward, (180 - Vector2.Angle (vectorRuchu, vectorPoprzedni))/20);
							} else {
									this.transform.Rotate (Vector3.forward, (-Vector2.Angle (vectorRuchu, vectorPoprzedni))/20);
							}
						}
			beginning = false;
		}*/
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
	}
	void changeDir() {
		if (destination.transform.position == waypointA.transform.position) {
			ConsoleScript.scen = 0;
			typSkr = 2;
						destination = waypointB;
				} else
			if (destination.transform.position == waypointB.transform.position) {
			typSkr = 1;
			ConsoleScript.scen = 1;
						destination = waypointC;
				} else
				if (destination.transform.position == waypointC.transform.position) {
			typSkr = 2;
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
			typSkr = 1;
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
			typSkr = 2;
			ConsoleScript.scen = 8;
						destination = waypointJ;
				} else 
											if (destination.transform.position == waypointJ.transform.position) {
			ConsoleScript.scen = 9;
						destination = waypointK;
				} else
												if (destination.transform.position == waypointK.transform.position) {
			typSkr = 1;
			ConsoleScript.scen = 10;
						destination = waypointL;
				} else
													if (destination.transform.position == waypointL.transform.position) {
			typSkr = 2;
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
		vectorRuchu = new Vector2 (this.transform.position.x - destination.transform.position.x, this.transform.position.y - destination.transform.position.y);
	}

}
