using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour{

	public void Update()
	{
	    if(Input.GetKeyDown(KeyCode.P))
	{
		SceneManager.LoadScene("Game");
	}
	}

    public void QuitGame()
	{
		Application.Quit();
	}
}
