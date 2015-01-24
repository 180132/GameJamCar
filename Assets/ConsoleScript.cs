using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConsoleScript : MonoBehaviour {
	string sytuacja = "Pierwszy tekst wyświetlany za pomoca textfielda, powinien wyświetlać się literka po literce.";
	string tmp="";
	Text text;
	int obliczenia;
	int size;
	bool isAllText;
	// Use this for initialization
	void Start () {
		text = GameObject.Find("Konsola").GetComponent<Text>();
		obliczenia = 0;
		size = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (size < sytuacja.Length) {
			if((obliczenia++)%2==0){
				tmp+=sytuacja[size];
				text.text=tmp;
				size++;
			}

		}
	}
}
