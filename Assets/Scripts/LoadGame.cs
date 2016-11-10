using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using TouchScript.Gestures;

public class LoadGame : MonoBehaviour {

	public int valor;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartGameButton(){
		SceneManager.LoadScene (1);
	}


	public void LoadAnyScene(){
		SceneManager.LoadScene (valor);
	}

	public void LoadSceneAndQuestions(){
		SceneManager.LoadScene (valor);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
