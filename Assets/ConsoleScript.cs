using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConsoleScript : MonoBehaviour {

	public static int scen;

	string sytuacja = "$What do we do now?";
	string tmp;
	public static Text text;
	int obliczenia;
	int zm;
	float timerWin;
	float timerLose;
	int size;
	bool isAllText;
	Text button;
	Scenario scenariusze;
	public int scenId;

	void Start () {
		Debug.Log ("Załączam się");
		scenId = -1;
		scenariusze = gameObject.AddComponent<Scenario>();
		scen = 0;
		timerWin = -1;
		timerLose = -1;
		text = GameObject.Find("Konsola").GetComponent<Text>();
		obliczenia = 0;
		size = 0;
		for (int i=1; i<=6; i++) {
			GameObject.Find ("Button" + i).GetComponent<Button>().image.enabled = false;
			GameObject.Find ("Button" + i + "_Text").GetComponent<Text>().text = "";

				}		
		OnEnable ();
	}
	
	// Update is called once per frame

	void Update () {
		if (timerWin > 0) {
			timerWin-=Time.deltaTime;
				}
		if (timerWin <= 0 && timerWin > -1) {
			Application.LoadLevel("Win");
		}

		if (timerLose > 0) {
			timerLose-=Time.deltaTime;
		}
		if (timerLose <= 0 && timerLose > -1) {
			Application.LoadLevel("Game Over Screen");
		}
	}


	public void createButton(int numberOfButton, string textOnButton){
		GameObject.Find("Button" + numberOfButton).GetComponent<Button>().image.enabled = true;
		GameObject.Find ("Button" + numberOfButton + "_Text").GetComponent<Text> ().text = textOnButton;
		GameObject.Find ("Button" + numberOfButton).GetComponent<Button> ().onClick.AddListener(() => {
			Debug.Log("Tekst");
			string answer = scenariusze.getAnswer(scenId,numberOfButton-1);
			if(answer.Equals("Drive...")){
				MovePoints.ruch = true; deleteButtons (answer);
			}
			else{
				MovePoints.ruch = false; deleteButtons (answer);
				if(answer.Equals("Dzwonisz do Spierka")){
					timerWin = 3f;
					//Application.LoadLevel("Win");

				}
				else{ 
					timerLose = 3f;
				
				}
			}
		}); 
	}

	public void GoToGameOver(){
		Application.LoadLevel("Game Over Screen");
	}

	public void GoToWin(){
		Application.LoadLevel("Win");
	}

	void deleteButtons(string newText){
		for (int i=1; i<=6; i++) {
			GameObject.Find ("Button" + i).GetComponent<Button>().image.enabled = false;
			GameObject.Find ("Button" + i + "_Text").GetComponent<Text>().text = "";
			setText (newText);
		}	
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
		scenId = scen;
		setText(scenariusze.getElement(scenId,0));
		for (int element=1; element<=3; element++) {

			if(!scenariusze.getElement (scenId,element).Equals("")) createButton (element, scenariusze.getElement(scenId,element));
				}



	}
	
}
