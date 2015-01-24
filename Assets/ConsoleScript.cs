using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConsoleScript : MonoBehaviour {

	public static int scen;

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

		scenariusze = new Scenario ();
		scen = 0;
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

	}


	public void createButton(int numberOfButton, string textOnButton, int scenarioElement){
		GameObject.Find("Button" + numberOfButton).GetComponent<Button>().image.enabled = true;
		GameObject.Find ("Button" + numberOfButton + "_Text").GetComponent<Text> ().text = textOnButton;
		GameObject.Find ("Button" + numberOfButton).GetComponent<Button> ().onClick.AddListener(() => {
			if(scenariusze.getAnswer(scenarioElement,numberOfButton-1).Equals("Drive...")){
				MovePoints.ruch = true; deleteButtons (scenariusze.getAnswer(scenarioElement,numberOfButton-1));
			}
			else{
				MovePoints.ruch = false; deleteButtons (scenariusze.getAnswer(scenarioElement,numberOfButton-1));
				//Application.LoadLevel(Game Over Screen);
			}
		}); 

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
		setText(scenariusze.getElement(scen,0));
		for (int element=1; element<=3; element++) {

			if(!scenariusze.getElement (scen,element).Equals("")) createButton (element, scenariusze.getElement(scen,element),scen);
				}



	}
	
}
