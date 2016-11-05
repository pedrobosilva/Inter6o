using UnityEngine;
using System.Collections;
using System;
using TouchScript.Gestures;

public class FlickToOpen : MonoBehaviour {

	public GameObject ObjectToOpen;
	public GameObject ObjectToClose;

	private float flickPosition;

	// Use this for initialization
	void Start () {
		//flickPosition = GetComponent<FlickGesture> ().Flicked;
	}


	void OnEnable(){
		GetComponent<FlickGesture> ().Flicked += openGameObject;
	}

	// Update is called once per frame
	void Update () {

	}

	void openGameObject(object sender, EventArgs e){
		var gesture = sender as FlickGesture;

		if (gesture.ScreenPosition.x < gesture.PreviousScreenPosition.x) {
			Debug.Log ("Coloque aqui o Tween");
		}

	}
}
