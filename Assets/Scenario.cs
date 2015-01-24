using UnityEngine;
using System.Collections;

public class Scenario : MonoBehaviour {

	private string[,] scenariusz;
	private string[,] odpowiedzi;

	public Scenario(){
		scenariusz = new string[,]{
			{"","Lewo","Prosto","Prawo"},
			{"","Lewo","Prosto","Prawo"},
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
			{"Wyjechałeś z miasta, game jam się skończy zanim wrócisz! Przecież to Łódź w godzinach szczytu","Jesteś na ulicy Politechniki, student wpadł ci pod koła, game over!","Drive..."},
			{"Drive...","Złapali narkomanów(trzynastolatków) którzy posiadali 0.1 grama, policja zablokowała przejazd","Wpadłeś w dziure"},
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
		Debug.Log (first + "  " + second);
		return scenariusz[first, second];
	}

	public string getAnswer(int first, int second){

		return odpowiedzi[first, second];
	}
		


}
