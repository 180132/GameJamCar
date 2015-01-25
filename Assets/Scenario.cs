using UnityEngine;
using System.Collections;

public class Scenario : MonoBehaviour {

	private string[,] scenariusz;
	private string[,] odpowiedzi;

	public Scenario(){
		scenariusz = new string[,]{
			{"We are on the Piotrkowska street. It's one of the finest streets in Lodz, however there is HUUGE traffic jam. What do we do now? ","Left","Straight","Right"},
			{"We are on the Tymienieckiego street. Heavy snow is covering all holes in the streets... What do we do now?","Left","Straight","Right"},
			{"We are on the Kilińskiego street. Ahead there is the gas station, and gas in our auto is only hypthetical. What do we do now? ","Left","Straight","Right"},
			{"We are on the Fabryczna street. There are factories around us, and we cannot see a thing due to snow. What do we do now?","Left","Straight","Right"},
			{"We are on the Przędzalniana street. One phone is out, so only one with we hav one phone left ","Left","Straight","Right"},
			{"We are on the Milionowa street. We are in the middle of noweher. What do we do now?","Left","Straight",""},
			{"We are on the Łęczycka stree. Our engine have suddenly stopped, but we managed to run it again. What do we do now?","Left","Straight","Right"},
			{"We are on the Przybyszewskiego street. Second phone is out, we are driving using our memory. What do we do now?","Left","","Right"},
			{"We are on the Śmigłego-Rydza street. It's a big street with big traffic jam and road works. But there is one worse street... What do we do now","Left","Straight","Right"},
			{"We are again on the Śmigłego-Rydza street. The broken bus is in the middle of the crossing. What do we do now?","","Straight","Right"},
			{"We are on the Zbiorcza street. The lanterns are turned off. We cannot see the adress. What do we do now?","Left","Straight",""},
			{"We are on the Sarnia street. It's freezing cold outside and we are running out of petrol. What do we do now?","","Straight","Right"},
			{"We manage to get to the Pilsudskiego street. All streets around us are closed","Call host's phone","",""},
		};

		odpowiedzi = new string[,]{
			{"You get out from the center of Lodz, you won't be able to get to game jam...","Now you have to turn right, so you have to lose, sry :-(","Drive..."},
			{"Drive...","They catched kids, who are known criminals. Police blocked the road","They catched kids, who are known criminals. Police blocked the road"},
			{"The gas station is the local mafia's residence, we are killed","The gas station is the local mafia's residence, we are killed","Drive..."},
			{"We ran into the hole in the street. Our wheel is out...","We ran into the hole in the street. Our wheel is out...","Drive..."},
			{"We saw the unicorn, so we headed its way. We didn't manage to get to the game jam","We saw the unicorn, so we headed its way. We didn't manage to get to the game jam","Drive..."},
			{"Drive...","Our car has exploded","Our car has blown up"},
			{"Drive...","Asteroid hit our car","Asteroid hit our car"},
			{"Drive...","One of us saw amazing girl walking down the street, and wi hit the tree...","One of us saw amazing girl walking down the street, and wi hit the tree..."},
			{"The univeres has collapsed, because we have divided by 0","Drive...","The univere has collapsed, because we have divided by 0"},
			{"We have hit the bus and we are killed","We have hit the bus and we are killed","Drive..."},
			{"Drive...","One of us has spilled the hot coffe , which led to the accident(how, I don't know 'cause I'm dead)","One of us has spilled the hot coffe , which led to the accident(how, I don't know 'cause I'm dead)"},
			{"Our car is trap car, so it has exploded","Our car is trap car, so it has exploded","Drive..."},
			{"He led you to the entrace","",""},
			
			
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
