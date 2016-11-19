using UnityEngine;
using System.Collections;
using System;
using TouchScript.Gestures;

public class TapToOpenGrupoVSGrupo : MonoBehaviour {

	public GameObject ObjectToOpen;
	public GameObject button;
	public GameObject ObjectToClose;
	public GameObject ObjectToClose2;
	public GameObject perguntaCanvas;

	private float flickPosition;

	public enum tipoDeTema{Arte,Esporte,Radio,Cinema, História, Propaganda};
	public tipoDeTema tipo;

	// Use this for initialization
	void Start () {
		//flickPosition = GetComponent<FlickGesture> ().Flicked;
	}


	void OnEnable(){
		GetComponent<TapGesture> ().Tapped += randomGroup;
	}

	// Update is called once per frame
	void Update () {

	}

	void randomGroup(object sender, EventArgs e){
		QuestionControllScript.Instance.FunctionGrupoVSGrupo ();


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

	}

	public void openGameObject(){
		//var gesture = sender as TapGesture;


		iTween.MoveTo (Camera.main.gameObject,iTween.Hash(
			"x", -1.45f,
			"y", 0.68f,
			"z", -8.75f,
			"time", 2,
			"speed", 2,
			"looptype", iTween.LoopType.none,
			"easetype", iTween.EaseType.linear));

		QuestionControllScript.Instance.qtdPerguntasTentada = 0;

		QuestionControllScript.Instance.SetQuestion();


		QuestionControllScript.Instance.contaPerguntas += 1;

		QuestionControllScript.Instance.HUDGrupoVSGrupo.SetActive (false);

		perguntaCanvas.SetActive (true);



		if (QuestionControllScript.Instance.vezAzul == true) {
			QuestionControllScript.Instance.PontosAzul += 40;
		}

		if (QuestionControllScript.Instance.vezVermelho == true) {
			QuestionControllScript.Instance.PontosVermelho += 40;

		}


		ObjectToClose.SetActive (false);
		ObjectToClose2.SetActive (false);
		button.SetActive (false);
		ObjectToOpen.SetActive (true);

	}
}
