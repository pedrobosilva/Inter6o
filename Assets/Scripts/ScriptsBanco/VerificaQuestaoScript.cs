﻿using UnityEngine;
using System.Collections;

public class VerificaQuestaoScript : MonoBehaviour {

	public static VerificaQuestaoScript Instance;

	public GameObject CanvasCuriosidade;

	public GameObject Curiosidade0;
	public GameObject Curiosidade1;
	public GameObject Curiosidade2;
	public GameObject Curiosidade3;

	public GameObject confetesGB;
	public GameObject canvasErrado;
	public GameObject canvasCorreto;

	public bool respostaCorreta = false;

	// Use this for initialization
	void Awake () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnTriggerEnter(Collider colision){
		if (colision.name == "Resposta0") {
			Curiosidade0.transform.parent.gameObject.SetActive (true);

			//colision.gameObject.SetActive (false);

			/*iTween.MoveTo (Curiosidade0.transform.parent.gameObject, iTween.Hash (
			"y",0.19,
			"speed", 0.5f,
			"easetype", iTween.EaseType.easeOutQuint));	

			iTween.RotateBy (Curiosidade0.transform.parent.gameObject, iTween.Hash (
				"z", 10
			)); */

			CanvasCuriosidade.SetActive (true);
			colision.gameObject.GetComponent<ButtonScript> ().goFlick = false;
			colision.gameObject.transform.localPosition = (new Vector3 (0.74f, 0.54f, 0));
			//colision.gameObject.GetComponent<ButtonScript> ().VoltarAPosicaoInicial();



			if (colision.gameObject.GetComponent<ButtonScript> ().isCorrect == true && !AudioControllerGame.Instance.audioSource.isPlaying && !VerificaCuriosidadeScript.Instance.verificarCuriosidades) {
				confetesGB.SetActive (true);
				canvasCorreto.SetActive (true);
				AudioControllerGame.Instance.PlaySound (SoundGames.RespostaCorretaSound);
				respostaCorreta = true;
			}

			if(colision.gameObject.GetComponent<ButtonScript> ().isCorrect == false && !AudioControllerGame.Instance.audioSource.isPlaying && !VerificaCuriosidadeScript.Instance.verificarCuriosidades){
				canvasErrado.SetActive (true);
				AudioControllerGame.Instance.PlaySound (SoundGames.RespostaErradaSound);
			}
		

		}
			
			if (colision.name == "Resposta1") {
			
			Curiosidade1.transform.parent.gameObject.SetActive (true);


		/*	iTween.MoveTo (Curiosidade1.transform.parent.gameObject, iTween.Hash (
				"y",0.19,
				"speed", 0.5f,
				"easetype", iTween.EaseType.easeOutQuint));	

			iTween.RotateBy (Curiosidade1.transform.parent.gameObject, iTween.Hash (
				"z", 10
			));  */
			CanvasCuriosidade.SetActive (true);
			colision.gameObject.GetComponent<ButtonScript> ().goFlick = false;
			colision.gameObject.transform.localPosition = (new Vector3 (0.74f, 0.54f, 0));
			//colision.gameObject.GetComponent<ButtonScript> ().VoltarAPosicaoInicial();

		

			if (colision.gameObject.GetComponent<ButtonScript> ().isCorrect == true && !AudioControllerGame.Instance.audioSource.isPlaying && !VerificaCuriosidadeScript.Instance.verificarCuriosidades) {
				confetesGB.SetActive (true);
				canvasCorreto.SetActive (true);
				AudioControllerGame.Instance.PlaySound (SoundGames.RespostaCorretaSound);
				respostaCorreta = true;
			} 

			if(colision.gameObject.GetComponent<ButtonScript> ().isCorrect == false && !AudioControllerGame.Instance.audioSource.isPlaying && !VerificaCuriosidadeScript.Instance.verificarCuriosidades){
				canvasErrado.SetActive (true);
				AudioControllerGame.Instance.PlaySound (SoundGames.RespostaErradaSound);
			}

		
			}
	
			if (colision.name == "Resposta2") {

			Curiosidade2.transform.parent.gameObject.SetActive (true);

			/* iTween.MoveTo (Curiosidade2.transform.parent.gameObject, iTween.Hash (
				"y",0.19,
				"speed", 0.5f,
				"easetype", iTween.EaseType.easeOutQuint));	

			iTween.RotateBy (Curiosidade2.transform.parent.gameObject, iTween.Hash (
				"z", 10
			)); */

			CanvasCuriosidade.SetActive (true);
			colision.gameObject.GetComponent<ButtonScript> ().goFlick = false;
			colision.gameObject.transform.localPosition = (new Vector3 (0.74f, 0.54f, 0));
			//colision.gameObject.GetComponent<ButtonScript> ().VoltarAPosicaoInicial();

		

			if (colision.gameObject.GetComponent<ButtonScript> ().isCorrect == true && !AudioControllerGame.Instance.audioSource.isPlaying && !VerificaCuriosidadeScript.Instance.verificarCuriosidades) {
				confetesGB.SetActive (true);
				canvasCorreto.SetActive (true);
				AudioControllerGame.Instance.PlaySound (SoundGames.RespostaCorretaSound);
				respostaCorreta = true;

			} 

			if(colision.gameObject.GetComponent<ButtonScript> ().isCorrect == false && !AudioControllerGame.Instance.audioSource.isPlaying && !VerificaCuriosidadeScript.Instance.verificarCuriosidades){
				canvasErrado.SetActive (true);
				AudioControllerGame.Instance.PlaySound (SoundGames.RespostaErradaSound);
			}


			}

			if (colision.name == "Resposta3") {
			
			Curiosidade3.transform.parent.gameObject.SetActive (true);

			/* iTween.MoveTo (Curiosidade3.transform.parent.gameObject, iTween.Hash (
				"y",0.19,
				"speed", 0.5f,
				"easetype", iTween.EaseType.easeOutQuint));	

			iTween.RotateBy (Curiosidade3.transform.parent.gameObject, iTween.Hash (
				"z", 10
			)); */

			CanvasCuriosidade.SetActive (true);
			colision.gameObject.GetComponent<ButtonScript> ().goFlick = false;
			colision.gameObject.transform.localPosition = (new Vector3 (0.74f, 0.54f, 0));
			//colision.gameObject.GetComponent<ButtonScript> ().VoltarAPosicaoInicial();


			if (colision.gameObject.GetComponent<ButtonScript> ().isCorrect == true && !AudioControllerGame.Instance.audioSource.isPlaying && !VerificaCuriosidadeScript.Instance.verificarCuriosidades) {
				confetesGB.SetActive (true);
				canvasCorreto.SetActive (true);
				AudioControllerGame.Instance.PlaySound (SoundGames.RespostaCorretaSound);
				respostaCorreta = true;
			} 

			if(colision.gameObject.GetComponent<ButtonScript> ().isCorrect == false && !AudioControllerGame.Instance.audioSource.isPlaying && !VerificaCuriosidadeScript.Instance.verificarCuriosidades){
				canvasErrado.SetActive (true);
				AudioControllerGame.Instance.PlaySound (SoundGames.RespostaErradaSound);
			}


			}
	}
}
