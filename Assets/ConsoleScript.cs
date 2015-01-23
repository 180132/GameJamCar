using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConsoleScript : MonoBehaviour {
	string sytuacja = "Pierwszy tekst wyświetlany za pomoca textfielda, powinien wyświetlać się literka po literce";
	string tmp="";
	Text text;
	// Use this for initialization
	void Start () {
		text = GameObject.Find("Konsola").GetComponent<Text>();
		for (int i=0; i<sytuacja.Length; i++) {

			tmp+=sytuacja[i];
			text.text=tmp;
			System.Threading.Thread.Sleep(2);
				}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
