using UnityEngine;
using System.Collections;

public class VerificaCuriosidadeScript : MonoBehaviour {

	public static VerificaCuriosidadeScript Instance;

	public GameObject CanvasCuriosidade;

	public GameObject Curiosidade0;
	public GameObject Curiosidade1;
	public GameObject Curiosidade2;
	public GameObject Curiosidade3;

	public GameObject[] Respostas;

	private Vector3 initialCuriosidade0;
	private Vector3 initialCuriosidade1;
	private Vector3 initialCuriosidade2;
	private Vector3 initialCuriosidade3;

	public GameObject Temas1;
	public GameObject canvasInGame;
	public GameObject RespostasCuriosidade;

	public GameObject[] canvasFlicker;

	public bool verificarCuriosidades;
	public GameObject BackgroundPontuacaoCorreta;
	public GameObject HUDPergunta;

	public GameObject pontuacaoAnim;

	public GameObject[] vaziosRotCuriosidade;
	public GameObject[] vaziosCuriosidade;


	void Awake(){
		Instance = this;
	}
	// Use this for initialization
	void Start () {

		initialCuriosidade0 = new Vector3 (Curiosidade0.transform.position.x, Curiosidade0.transform.position.y, Curiosidade0.transform.position.z);
		initialCuriosidade1 = new Vector3 (Curiosidade1.transform.position.x, Curiosidade1.transform.position.y, Curiosidade1.transform.position.z);
		initialCuriosidade2 = new Vector3 (Curiosidade2.transform.position.x, Curiosidade2.transform.position.y, Curiosidade2.transform.position.z);
		initialCuriosidade3 = new Vector3 (Curiosidade3.transform.position.x, Curiosidade3.transform.position.y, Curiosidade3.transform.position.z);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void VoltaRotacaoCuriosidade(){
		vaziosRotCuriosidade[0].transform.position = vaziosCuriosidade[0].transform.position;
		vaziosRotCuriosidade[0].transform.localRotation = Quaternion.Euler (0, 0, 0);

		vaziosRotCuriosidade[1].transform.position = vaziosCuriosidade[1].transform.position;
		vaziosRotCuriosidade[1].transform.localRotation = Quaternion.Euler (0, 0, 0);

		vaziosRotCuriosidade[2].transform.position = vaziosCuriosidade[1].transform.position;
		vaziosRotCuriosidade[2].transform.localRotation = Quaternion.Euler (0, 0, 0);

		vaziosRotCuriosidade[3].transform.position = vaziosCuriosidade[1].transform.position;
		vaziosRotCuriosidade[3].transform.localRotation = Quaternion.Euler (0, 0, 0);

	}

	public void VoltarAosTemas(){

		Temas1.SetActive (true);
		canvasInGame.SetActive (true);
		RespostasCuriosidade.SetActive (false);
		QuestionControllScript.Instance.groupSelected = false;

		canvasFlicker [0].SetActive (false);
		canvasFlicker [1].SetActive (false);
		canvasFlicker [2].SetActive (false);
		canvasFlicker [3].SetActive (false);

		Curiosidade0.SetActive (true);
		Curiosidade1.SetActive (true);
		Curiosidade2.SetActive (true);
		Curiosidade3.SetActive (true);

		VoltaRotacaoCuriosidade ();

		VerificaQuestaoScript.Instance.respostaCorreta = false;
		verificarCuriosidades = false;

		QuestionControllScript.Instance.qtdPerguntasTentada = 0;
	

		Respostas [0].SetActive (true);
		Respostas [1].SetActive (true);
		Respostas [2].SetActive (true);
		Respostas [3].SetActive (true);
		HUDPergunta.SetActive (true);
		BackgroundPontuacaoCorreta.SetActive (false);

		iTween.MoveTo (Camera.main.gameObject,iTween.Hash(
			"x", 0.27f,
			"y", -0.06f,
			"z", -10.1f,
			"time", 2,
			"speed", 2,
			"looptype", iTween.LoopType.none,
			"easetype", iTween.EaseType.linear));

	}

	public void ProximaPergunta(){
		QuestionControllScript.Instance.SetQuestion ();

		Respostas [0].SetActive (true);
		Respostas [1].SetActive (true);
		Respostas [2].SetActive (true);
		Respostas [3].SetActive (true);
		HUDPergunta.SetActive (true);
		BackgroundPontuacaoCorreta.SetActive (false);

		VoltaRotacaoCuriosidade ();

		VerificaQuestaoScript.Instance.respostaCorreta = false;
		verificarCuriosidades = false;

		Curiosidade0.SetActive (true);
		Curiosidade1.SetActive (true);
		Curiosidade2.SetActive (true);
		Curiosidade3.SetActive (true);

		Curiosidade0.transform.parent.gameObject.SetActive (false);
		Curiosidade1.transform.parent.gameObject.SetActive (false);
		Curiosidade2.transform.parent.gameObject.SetActive (false);
		Curiosidade3.transform.parent.gameObject.SetActive (false);

		canvasFlicker [0].SetActive (false);
		canvasFlicker [1].SetActive (false);
		canvasFlicker [2].SetActive (false);
		canvasFlicker [3].SetActive (false);



		iTween.MoveTo (Camera.main.gameObject,iTween.Hash(
			"x", -1.45f,
			"y", 0.68f,
			"z", -8.75f,
			"time", 2,
			"speed", 2,
			"looptype", iTween.LoopType.none,
			"easetype", iTween.EaseType.linear));

	
	}

	void setarFlickActive(){
		canvasFlicker [0].SetActive (true);
		canvasFlicker [1].SetActive (true);
		canvasFlicker [2].SetActive (true);
		canvasFlicker [3].SetActive (true);
	}

	void OnTriggerEnter(Collider colision){
		if (colision.name == "Curiosidade0") {
			if (VerificaQuestaoScript.Instance.respostaCorreta == true) {

				Curiosidade0.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
				Curiosidade0.transform.position = initialCuriosidade0;
				//Curiosidade0.SetActive (false);
				CanvasCuriosidade.SetActive (false);
				Respostas [0].SetActive (false);
				setarFlickActive ();
				pontuacaoAnim.SetActive (true);
				BackgroundPontuacaoCorreta.SetActive (true);
				verificarCuriosidades = true;
				HUDPergunta.SetActive (false);
				VerificaQuestaoScript.Instance.respostaCorreta = false;
				Curiosidade0.GetComponent<PlaySound1> ().StopSound ();
				AudioControllerGame.Instance.PlaySound (SoundGames.MoedaSound);



			} else {
				Curiosidade0.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
				Curiosidade0.transform.position = initialCuriosidade0;
			//	Curiosidade0.SetActive (false);
				Curiosidade0.transform.parent.gameObject.SetActive (false);
				Curiosidade0.transform.parent.gameObject.SetActive (false);
				CanvasCuriosidade.SetActive (false);
				Respostas [0].SetActive (false);
				VerificaQuestaoScript.Instance.respostaCorreta = false;
				Curiosidade0.GetComponent<PlaySound1> ().StopSound ();

				if (QuestionControllScript.Instance.GrupoVSGrupoGame == true) {
					QuestionControllScript.Instance.ContaPontuacaoGrupoVSGrupo ();
				}
			}
		}

		if (colision.name == "Curiosidade1") {
			if (VerificaQuestaoScript.Instance.respostaCorreta == true) {
				Curiosidade1.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
				Curiosidade1.transform.position = initialCuriosidade0;
				//Curiosidade1.SetActive (false);
				Curiosidade1.transform.parent.gameObject.SetActive (false);
				CanvasCuriosidade.SetActive (false);
				Respostas [1].SetActive (false);
				setarFlickActive ();
				pontuacaoAnim.SetActive (true);
				verificarCuriosidades = true;
				HUDPergunta.SetActive (false);
				BackgroundPontuacaoCorreta.SetActive (true);
				VerificaQuestaoScript.Instance.respostaCorreta = false;
				Curiosidade1.GetComponent<PlaySound1> ().StopSound ();
				AudioControllerGame.Instance.PlaySound (SoundGames.MoedaSound);

			} else {
				Curiosidade1.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
				Curiosidade1.transform.position = initialCuriosidade0;
				//Curiosidade1.SetActive (false);
				Curiosidade1.transform.parent.gameObject.SetActive (false);
				CanvasCuriosidade.SetActive (false);
				Respostas [1].SetActive (false);
				VerificaQuestaoScript.Instance.respostaCorreta = false;
				Curiosidade1.GetComponent<PlaySound1> ().StopSound ();

				if (QuestionControllScript.Instance.GrupoVSGrupoGame == true) {
					QuestionControllScript.Instance.ContaPontuacaoGrupoVSGrupo ();
				}
			}
		}

		if (colision.name == "Curiosidade2") {
			if (VerificaQuestaoScript.Instance.respostaCorreta == true) {
				Curiosidade2.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
				Curiosidade2.transform.position = initialCuriosidade0;
				//Curiosidade2.SetActive (false);
				Curiosidade2.transform.parent.gameObject.SetActive (false);
				CanvasCuriosidade.SetActive (false);
				Respostas [2].SetActive (false);
				setarFlickActive ();
				pontuacaoAnim.SetActive (true);
				verificarCuriosidades = true;
				HUDPergunta.SetActive (false);
				BackgroundPontuacaoCorreta.SetActive (true);
				VerificaQuestaoScript.Instance.respostaCorreta = false;
				Curiosidade2.GetComponent<PlaySound1> ().StopSound ();
				AudioControllerGame.Instance.PlaySound (SoundGames.MoedaSound);
		
			} else {
				Curiosidade2.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
				Curiosidade2.transform.position = initialCuriosidade0;
				//Curiosidade2.SetActive (false);
				Curiosidade2.transform.parent.gameObject.SetActive (false);
				CanvasCuriosidade.SetActive (false);
				Respostas [2].SetActive (false);
				VerificaQuestaoScript.Instance.respostaCorreta = false;
				Curiosidade2.GetComponent<PlaySound1> ().StopSound ();

				if (QuestionControllScript.Instance.GrupoVSGrupoGame == true) {
					QuestionControllScript.Instance.ContaPontuacaoGrupoVSGrupo ();
				}
			}
		}

		if (colision.name == "Curiosidade3") {
			if (VerificaQuestaoScript.Instance.respostaCorreta == true) {
				Curiosidade3.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
				Curiosidade3.transform.position = initialCuriosidade0;
				//Curiosidade3.SetActive (false);
				Curiosidade3.transform.parent.gameObject.SetActive (false);
				CanvasCuriosidade.SetActive (false);
				Respostas [3].SetActive (false);
				setarFlickActive ();
				pontuacaoAnim.SetActive (true);
				verificarCuriosidades = true;
				HUDPergunta.SetActive (false);
				BackgroundPontuacaoCorreta.SetActive (true);
				VerificaQuestaoScript.Instance.respostaCorreta = false;
				Curiosidade3.GetComponent<PlaySound1> ().StopSound ();
				AudioControllerGame.Instance.PlaySound (SoundGames.MoedaSound);

			} else {
				Curiosidade3.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
				Curiosidade3.transform.position = initialCuriosidade0;
				//Curiosidade3.SetActive (false);
				Curiosidade3.transform.parent.gameObject.SetActive (false);
				CanvasCuriosidade.SetActive (false);
				Respostas [3].SetActive (false);
				VerificaQuestaoScript.Instance.respostaCorreta = false;
				Curiosidade3.GetComponent<PlaySound1> ().StopSound ();

				if (QuestionControllScript.Instance.GrupoVSGrupoGame == true) {
					QuestionControllScript.Instance.ContaPontuacaoGrupoVSGrupo ();
				}
			}
		}

		if (colision.name == "Curiosidade0" && verificarCuriosidades == true) {
			Curiosidade0.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
			Curiosidade0.transform.position = initialCuriosidade0;
			Curiosidade0.SetActive (false);
			CanvasCuriosidade.SetActive (false);
			Respostas [0].SetActive (false);
			canvasFlicker [0].SetActive (false);
			pontuacaoAnim.SetActive (true);
			QuestionControllScript.Instance.ContaPontuacao ();
			VerificaQuestaoScript.Instance.respostaCorreta = false;
			Curiosidade0.GetComponent<PlaySound1> ().StopSound ();
			AudioControllerGame.Instance.PlaySound (SoundGames.MoedaSound);
		}

		if (colision.name == "Curiosidade1" && verificarCuriosidades == true) {
			Curiosidade1.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
			Curiosidade1.transform.position = initialCuriosidade0;
			Curiosidade1.SetActive (false);
			CanvasCuriosidade.SetActive (false);
			Respostas [1].SetActive (false);
			canvasFlicker [1].SetActive (false);
			pontuacaoAnim.SetActive (true);
			QuestionControllScript.Instance.ContaPontuacao ();
			VerificaQuestaoScript.Instance.respostaCorreta = false;
			Curiosidade1.GetComponent<PlaySound1> ().StopSound ();
			AudioControllerGame.Instance.PlaySound (SoundGames.MoedaSound);
		}

		if (colision.name == "Curiosidade2" && verificarCuriosidades == true) {
			Curiosidade2.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
			Curiosidade2.transform.position = initialCuriosidade0;
			Curiosidade2.SetActive (false);
			CanvasCuriosidade.SetActive (false);
			Respostas [2].SetActive (false);
			canvasFlicker [2].SetActive (false);
			pontuacaoAnim.SetActive (true);
			QuestionControllScript.Instance.ContaPontuacao ();
			VerificaQuestaoScript.Instance.respostaCorreta = false;
			Curiosidade2.GetComponent<PlaySound1> ().StopSound ();
			AudioControllerGame.Instance.PlaySound (SoundGames.MoedaSound);
		}

		if (colision.name == "Curiosidade3" && verificarCuriosidades == true) {
			Curiosidade3.GetComponent<ButtonScript> ().goFlickCuriosidade = false;
			Curiosidade3.transform.position = initialCuriosidade0;
			Curiosidade3.SetActive (false);
			CanvasCuriosidade.SetActive (false);
			Respostas [3].SetActive (false);
			canvasFlicker [3].SetActive (false);
			pontuacaoAnim.SetActive (true);
			QuestionControllScript.Instance.ContaPontuacao ();
			VerificaQuestaoScript.Instance.respostaCorreta = false;
			Curiosidade3.GetComponent<PlaySound1> ().StopSound ();
			AudioControllerGame.Instance.PlaySound (SoundGames.MoedaSound);
		}

	
	}
}
