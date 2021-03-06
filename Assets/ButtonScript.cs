﻿using System;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public static ButtonScript Instance;

	public bool Ctrl_Verific = false;

	public bool isCorrect = false;
	public Text AnswerText;
	public Text QuestionText;
	public Text CuriosidadeText;
	public enum type{pergunta,resposta,curiosidade}
	public type tipo; 
	public float tilt;
	private Rigidbody rb;
	private Vector3 velocity = Vector3.zero;
	private Vector3 laterPos;

	public GameObject backGroundZoom;

	public int respostanum;

	public AudioClip audioCuriosisidade;
	public AudioClip audioDaPergunta;
	public AudioClip audioDasAlternativas;
	public AudioSource audioSource;

	private Quaternion targetRotation;

	private Vector3 posicaoInitial;
	private Vector3 scaleInitial;
	private Vector3 rotacaoInicial;

	public GameObject vaziosRot;
	public GameObject respawnPosition;



	public bool goFlick = false;
	public bool goFlickCuriosidade = false;

	private void Awake()
	{
		Instance = this;

		targetRotation = transform.localRotation;
		rb = gameObject.GetComponent<Rigidbody> ();
	}

	void Start()
	{


		posicaoInitial = new Vector3 (transform.position.x, transform.position.y, -7);
		rotacaoInicial = new Vector3 (transform.rotation.x,transform.rotation.y,transform.rotation.z);

	}

	private void OnEnable()
	{
		
			GetComponent<TapGesture> ().Tapped += TapAction;
	
		
		GetComponent<FlickGesture> ().Flicked += FlickButton;

		//GetComponent<PanGesture> ().PanStarted += PanStartAction;
		//GetComponent<PanGesture> ().Panned += PanWhileAction;
		//GetComponent<PanGesture> ().PanCompleted += PanCompleteAction;
	}

	private void OnDisable()
	{
		GetComponent<TapGesture>().Tapped -= TapAction;

		GetComponent<FlickGesture> ().Flicked -= FlickButton;

		GetComponent<PanGesture> ().PanStarted -= PanStartAction;
		GetComponent<PanGesture> ().Panned -= PanWhileAction;
		GetComponent<PanGesture> ().PanCompleted -= PanCompleteAction;
	}


	public void SetQuestion(){
		
		//AnswerText.text = GameControl.gControl.perguntasList [0].textoDaPerguntaBd;
	
		if (tipo == type.pergunta) {

			QuestionText.text = GameControl.gControl.perguntasList [1].textoDaPerguntaBd;
		}

		if (tipo == type.resposta) {

			AnswerText.text = GameControl.gControl.perguntasList [1].respostasBd [respostanum].textoDaResposta;
		}

	}

	public void VoltaRotacaoBatata(){
		vaziosRot.transform.position = respawnPosition.transform.position;
		vaziosRot.transform.localRotation = Quaternion.Euler (0, 0, 0);


		/*vaziosRot [1].transform.position = respawnPosition[1].transform.position;
		vaziosRot [1].transform.localRotation = Quaternion.Euler (0, 0, 0);

		vaziosRot [2].transform.position = respawnPosition[2].transform.position;
		vaziosRot [2].transform.localRotation = Quaternion.Euler (0, 0, 0);

		vaziosRot [3].transform.position = respawnPosition[3].transform.position;
		vaziosRot [3].transform.localRotation = Quaternion.Euler (0, 0, 0); */

	}


	private void FlickButton(object sender, EventArgs e){
		
		var gesture = sender as FlickGesture;

		if (tipo == type.resposta && gesture.ScreenPosition.y > gesture.PreviousScreenPosition.y) {
			transform.position = new Vector3(transform.position.x, transform.position.y, -7.1f);
			//goFlick = true;

				iTween.MoveTo (gameObject.transform.parent.gameObject, iTween.Hash (
				"y", 1,
				"speed", 0.5f,
				"easetype", iTween.EaseType.easeOutQuint, 
				"oncompletetarget", gameObject,
				"oncomplete", "VoltaRotacaoBatata"

				));	

			//"oncomplete", Ctrl_Verific = true

			iTween.RotateBy (gameObject.transform.parent.gameObject, iTween.Hash (
				"z", 10,
				"oncomplete", "VoltaRotacaoBatata"
				));
	
				

			// Não vai precisar do GoFlick = true, tira a linha que depois eu arrumo certinho.
		
		}

		if (tipo == type.resposta && gesture.ScreenPosition.y < gesture.PreviousScreenPosition.y) {
			backGroundZoom.SetActive (false);
			transform.position = posicaoInitial;
		}

		if (tipo == type.curiosidade && gesture.ScreenPosition.y > gesture.PreviousScreenPosition.y) {
			// não vai precisar do goflickCuriosidade = true tira a linha que depois eu arrumo certinho.
			VerificaQuestaoScript.Instance.canvasCorreto.SetActive(false);
			VerificaQuestaoScript.Instance.canvasErrado.SetActive(false);
			goFlickCuriosidade = true;
		}
	}


	private	void PanStartAction(object sender, EventArgs e)
	{

		transform.position = new Vector3(transform.position.x, transform.position.y, -7.1f);
		backGroundZoom.SetActive (false);
	}

	private void PanWhileAction(object sender, EventArgs e)
	{
		
	}

	private void PanCompleteAction(object sender, EventArgs e)
	{
		


	}

	public void VoltarAPosicaoInicial(){
		transform.position = posicaoInitial;

		
	}

	void Update ()
	{
		


		if (goFlick == true) {



			transform.Translate (new Vector3 (0,0,-0.02f));
			backGroundZoom.SetActive (false);
		}
			
		if (goFlickCuriosidade == true) {

		
			// apagar a linha do Translate. 

			transform.Translate (new Vector3 (0,0,0.02f));
			backGroundZoom.SetActive (false);
		}


		//transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, .1f);
	}

	private void TapAction(object sender, EventArgs e)
	{

		if (tipo == type.resposta) {
			backGroundZoom.SetActive (true);
			transform.position = new Vector3 (2.87f, 0.77f, -7.59f);
		} else {
			return;
		}
	}



}
