using UnityEngine;
using System.Collections;

public class VerificaQuestaoScript : MonoBehaviour {

	public static VerificaQuestaoScript Instance;

	public GameObject CanvasCuriosidade;

	public GameObject Curiosidade0;
	public GameObject Curiosidade1;
	public GameObject Curiosidade2;
	public GameObject Curiosidade3;

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
			Curiosidade0.SetActive (true);
			CanvasCuriosidade.SetActive (true);
			colision.gameObject.GetComponent<ButtonScript> ().goFlick = false;
			colision.gameObject.GetComponent<ButtonScript> ().VoltarAPosicaoInicial();

			if (colision.gameObject.GetComponent<ButtonScript> ().isCorrect == true) {
				
				respostaCorreta = true;
			}

		

		}
			
			if (colision.name == "Resposta1") {
			
			Curiosidade1.SetActive (true);
			CanvasCuriosidade.SetActive (true);
			colision.gameObject.GetComponent<ButtonScript> ().goFlick = false;
			colision.gameObject.GetComponent<ButtonScript> ().VoltarAPosicaoInicial();

			if (colision.gameObject.GetComponent<ButtonScript> ().isCorrect == true) {
				
				respostaCorreta = true;
			}
		
			}
	
			if (colision.name == "Resposta2") {

			Curiosidade2.SetActive (true);
			CanvasCuriosidade.SetActive (true);
			colision.gameObject.GetComponent<ButtonScript> ().goFlick = false;
			colision.gameObject.GetComponent<ButtonScript> ().VoltarAPosicaoInicial();

			if (colision.gameObject.GetComponent<ButtonScript> ().isCorrect == true) {
				
				respostaCorreta = true;

			}


			}

			if (colision.name == "Resposta3") {
			
			Curiosidade3.SetActive (true);
			CanvasCuriosidade.SetActive (true);
			colision.gameObject.GetComponent<ButtonScript> ().goFlick = false;
			colision.gameObject.GetComponent<ButtonScript> ().VoltarAPosicaoInicial();

			if (colision.gameObject.GetComponent<ButtonScript> ().isCorrect == true) {
				
				respostaCorreta = true;
			}


			}
	}
}
