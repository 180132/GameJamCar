using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	public void changeScene(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
