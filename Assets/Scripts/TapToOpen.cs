using UnityEngine;
using System.Collections;
using System;
using TouchScript.Gestures;

public class TapToOpen : MonoBehaviour {

	public GameObject ObjectToOpen;
	public GameObject button;
	public GameObject ObjectToClose;

	private float flickPosition;

	// Use this for initialization
	void Start () {
		//flickPosition = GetComponent<FlickGesture> ().Flicked;
	}


	void OnEnable(){
		GetComponent<TapGesture> ().Tapped += openGameObject;
	}

	// Update is called once per frame
	void Update () {
	
	}

	void openGameObject(object sender, EventArgs e){
		//var gesture = sender as TapGesture;
			QuestionControllScript.Instance.SetQuestion();

			ObjectToClose.SetActive (false);
			button.SetActive (false);
			ObjectToOpen.SetActive (true);
			
	}
}
