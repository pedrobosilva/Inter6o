using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using TouchScript.Gestures;

public class LoadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartGameButton(){
		SceneManager.LoadScene (1);
	}
}
