using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntroScript : MonoBehaviour {
	Text text;
	float time;
	string napis = "$We are going to the Game Jam but we forgot the address...";
	int size;
	string tmp;
	// Use this for initialization
	void Start () {
		 text = GameObject.Find ("IntroText").GetComponent<Text> ();
		size = 1;
		time = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		if (time > 0) {
						Debug.Log (size + " " + napis.Length);
						if (size < napis.Length) {
								if (size % 1 == 0) {
										tmp += napis [size];
										text.text = tmp;
										size++;
								}
						}else{
				time -=Time.deltaTime;
			}

				} else {
			Application.LoadLevel("Game");
				}  
	}
}
