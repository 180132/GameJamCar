﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConsoleScript : MonoBehaviour {
<<<<<<< HEAD
	public static int a;
=======
	public static int scen;
>>>>>>> origin/master
	string sytuacja = "$What do we do now?";
	string tmp;
	public Text text;
	int obliczenia;
	int zm;
	int size;
	bool isAllText;
	Text button;
	Scenario scenariusze;
	
	// Use this for initialization
	void Start () {
<<<<<<< HEAD
		a = 0;
=======
		scenariusze = new Scenario ();
		scen = 0;
>>>>>>> origin/master
		text = GameObject.Find("Konsola").GetComponent<Text>();
		obliczenia = 0;
		size = 0;
		for (int i=1; i<=6; i++) {
			GameObject.Find ("Button" + i).GetComponent<Button>().image.enabled = false;
			GameObject.Find ("Button" + i + "_Text").GetComponent<Text>().text = "";

				}		
		OnEnable ();
		GameObject.Find ("Button" + 1).GetComponent<Button>().image.enabled = true;
		GameObject.Find ("Button" + 1 + "_Text").GetComponent<Text>().text = "Opcja1";
		if (GameObject.Find ("Button" + 1).GetComponent<Button> ()) {
			Debug.Log ("Obsługa przycisku");
				}
	}
	
	// Update is called once per frame

	void Update () {
		if(!Input.GetKeyDown(KeyCode.Return)){
			addElements (size++,sytuacja);

		}
	}

	bool addElements(int size, string scenariusz){
				if (size < scenariusz.Length) {
		
			tmp = "";
						int zm = 0;
			while((zm++)<size)tmp += scenariusz[zm];
						
						text.text = tmp;
			if(scenariusz [size].Equals('?')){
				createButtons (scenariusz, size);
				size=scenariusz.Length;
			}
		} 
		return true;
		}

	void createButtons(string scenariusz, int size){

		for (int index=0; index < howMany(scenariusz); index++) {
			string tymczasowy_tekst_buttona="";
			for (int j = size+1; !scenariusz[j].Equals('|'); j++) {
				tymczasowy_tekst_buttona+=scenariusz[j];

				size++;
			}
		
			GameObject.Find("Button1").GetComponent<Text>().text="Opcja1";
		}
	}
	
	int howMany(string tekst_scenariusza){
		int quantity=0;
			for(int index=0; index < tekst_scenariusza.Length; index++){
			if(tekst_scenariusza[index].Equals('|'))
			{
				quantity++;
			}
		}

		return quantity;
	}
	public void createButton(int numberOfButton, string textOnButton){
		GameObject.Find("Button" + numberOfButton).GetComponent<Button>().image.enabled = true;
		GameObject.Find ("Button" + numberOfButton + "_Text").GetComponent<Text> ().text = textOnButton;
		Debug.Log ("Test");
	}

	public void OnEnable(){
		MovePoints.collision += createEvent;
	}
	public void OnDisable(){
		MovePoints.collision -= createEvent;
	}


	public void setText(string newText){
		tmp = "";
		text.text = "";
		for (int index=0; index< newText.Length; index++) {
			if(index%1==0){
				tmp+=newText[index];
				text.text = tmp;
			}

		}
		}

	public void createEvent(){
		Debug.Log (scenariusze.getElement(0,1));
		for (int element=1; element<=3; element++) {
			createButton (element, scenariusze.getElement(0,element));
				}


	}



}
