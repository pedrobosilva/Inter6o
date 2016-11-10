using UnityEngine;
using System.Collections;
using System;
using TouchScript.Gestures;

public class FlickToOpen : MonoBehaviour {

	public GameObject ObjectToOpen;
	public GameObject ObjectToClose;
	public enum type { PerguntaImagem, Pergunta};
	public type tipo;

	public GameObject audioSourcePerguntaImagem;
	public GameObject audioSourcePergunta;

	private float flickPosition;

	// Use this for initialization
	void Start () {
		//flickPosition = GetComponent<FlickGesture> ().Flicked;
	}


	void OnEnable(){
		if (tipo == type.PerguntaImagem) {
			GetComponent<FlickGesture> ().Flicked += openGameObject;
		}
		if (tipo == type.Pergunta) {
			GetComponent<FlickGesture> ().Flicked += closeGameObject;
		}
	}

	// Update is called once per frame
	void Update () {

	}

	void openGameObject(object sender, EventArgs e){
		var gesture = sender as FlickGesture;

		if (gesture.ScreenPosition.x < gesture.PreviousScreenPosition.x) {

			audioSourcePerguntaImagem.GetComponent<ButtonScript> ().audioSource.Stop ();
			//Debug.Log ("Coloque aqui o Tween");

			iTween.MoveTo (Camera.main.gameObject, iTween.Hash (
				"x", 2.14f,
				"y", 0.19f,
				"z", -8.57,
				"time", 2,
				"speed", 2,
				"looptype", iTween.LoopType.none,
				"easetype", iTween.EaseType.linear));
		}

	}

	void closeGameObject(object sender, EventArgs e){
		var gesture = sender as FlickGesture;

		if (gesture.ScreenPosition.x > gesture.PreviousScreenPosition.x) {
			//Debug.Log ("Coloque aqui o Tween");

			audioSourcePergunta.GetComponent<ButtonScript> ().audioSource.Stop ();

			iTween.MoveTo (Camera.main.gameObject,iTween.Hash(
				"x", -1.45f,
				"y", 0.68f,
				"z", -8.75f,
				"time", 2,
				"speed", 2,
				"looptype", iTween.LoopType.none,
				"easetype", iTween.EaseType.linear));
		}

	}
}
