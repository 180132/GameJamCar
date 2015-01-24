using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConsoleScript : MonoBehaviour {
	string sytuacja = "$What do we do now?";
	string tmp;
	public Text text;
	int obliczenia;
	int zm;
	int size;
	bool isAllText;
	Text button;
	
	// Use this for initialization
	void Start () {
		text = GameObject.Find("Konsola").GetComponent<Text>();
		obliczenia = 0;
		size = 0;
		for (int i=1; i<=6; i++) {
			GameObject.Find ("Button" + i).GetComponent<Button>().image.enabled = false;
			GameObject.Find ("Button" + i + "_Text").GetComponent<Text>().text = "";

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
			Debug.Log(scenariusz [size]);
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
			Debug.Log ("tmp: " + tymczasowy_tekst_buttona);
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
		Debug.Log ("Quantity: " + quantity);
		return quantity;
	}

	
}
