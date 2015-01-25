using UnityEngine;
using System.Collections;

public class Scenario : MonoBehaviour {

	private string[,] scenariusz;
	private string[,] odpowiedzi;

	public Scenario(){
		scenariusz = new string[,]{
			{"Jedziesz ulicą Politechniki. Zgraje studentów wracają w godzinach szczytu.","Lewo","Prosto","Prawo"},
			{"Jedziesz ulicą Tymienieckiego. ","Lewo","Prosto","Prawo"},
			{"","Lewo","Prosto","Prawo"},
			{"","Lewo","Prosto","Prawo"},
			{"","Lewo","Prosto","Prawo"},
			{"","Lewo","Prosto",""},
			{"","Lewo","Prosto","Prawo"},
			{"","Lewo","","Prawo"},
			{"","Lewo","Prosto","Prawo"},
			{"","","Prosto","Prawo"},
			{"","Lewo","Prosto",""},
			{"","","Prosto","Prawo"},
			{"","Zadzwoń do Spierka","",""},
		};

		odpowiedzi = new string[,]{
			{"Wyjechałeś z miasta, game jam się skończy zanim wrócisz! Przecież to Łódź w godzinach szczytu","Na następnym zakręcie musisz skręcić w lewo, więc już nie zdążysz na game jam","Drive..."},
			{"Drive...","Złapali narkomanów(trzynastolatków) którzy posiadali 0.1 grama, policja zablokowała przejazd","Wpadłeś w i urwało ci koło. :("},
			{"Samochód ci wybuchł","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!","Drive..."},
			{"","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!","Drive..."},
			{"","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!","Drive..."},
			{"Drive...","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!",""},
			{"Drive...","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!",""},
			{"Drive...","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!",""},
			{"","Drive...",""},
			{"","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!","Drive..."},
			{"Drive...","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!",""},
			{"","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!","Drive..."},
			{"","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!",""},
			
			
		};
	}
	public string getElement(int first, int second){

		return scenariusz[first, second];
	}

	public string getAnswer(int first, int second){
		Debug.Log ("Pytanie: " + first + "  " + second);
		return odpowiedzi[first, second];
	}
		


}
