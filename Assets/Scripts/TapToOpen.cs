using UnityEngine;
using System.Collections;
using System;
using TouchScript.Gestures;

public class TapToOpen : MonoBehaviour {

	public GameObject ObjectToOpen;
	public GameObject button;
	public GameObject ObjectToClose;

	private float flickPosition;

	public enum tipoDeTema{Arte,Esporte,Radio,Cinema, História, Propaganda};
	public tipoDeTema tipo;

	// Use this for initialization
	void Start () {
		//flickPosition = GetComponent<FlickGesture> ().Flicked;
	}


	void OnEnable(){
		GetComponent<TapGesture> ().Tapped += openGameObjectCinema;
	}

	// Update is called once per frame
	void Update () {
	
	}

	void openGameObjectCinema(object sender, EventArgs e){
		//var gesture = sender as TapGesture;

		Debug.Log ("Coloque o Tween Aqui");

		if (tipo == tipoDeTema.Cinema) {
			QuestionControllScript.Instance.TemaEscolhido = PerguntasClass.Temas.Cinema;
		}

		if (tipo == tipoDeTema.Esporte) {
			QuestionControllScript.Instance.TemaEscolhido = PerguntasClass.Temas.Esporte;
		}

		if (tipo == tipoDeTema.Arte) {
			QuestionControllScript.Instance.TemaEscolhido = PerguntasClass.Temas.Arte;
		}

		if (tipo == tipoDeTema.Radio) {
			QuestionControllScript.Instance.TemaEscolhido = PerguntasClass.Temas.Radio;
		}

		if (tipo == tipoDeTema.História) {
			QuestionControllScript.Instance.TemaEscolhido = PerguntasClass.Temas.História;
		}

		if (tipo == tipoDeTema.Propaganda) {
			QuestionControllScript.Instance.TemaEscolhido = PerguntasClass.Temas.Propaganda;
		}
		QuestionControllScript.Instance.SetQuestion();

			ObjectToClose.SetActive (false);
			button.SetActive (false);
			ObjectToOpen.SetActive (true);
			
	}
}
