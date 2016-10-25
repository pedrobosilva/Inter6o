using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class LoadQuestion : MonoBehaviour {

	public static LoadQuestion Instance;

	public GameObject ChooseQuestionCanvas;
	public GameObject BordaoQuestion;
	public GameObject FilmeQuestion;
	public GameObject MusicaQuestion;
	public GameObject RadioQuestion;
	public GameObject TVQuestion;

	public Transform CanvasParent;
	public GameObject ChooseTheme;

	public GameObject CuriosidadeCanvas;

	public GameObject umGrupo;
	public GameObject GrupoVS;

	public int contaVezRed = 0;
	public int contaVezBlue = 0;


	// Use this for initialization
	void Awake () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MudaContadorRed(){
		contaVezRed += 1;
	}

	public void MudaContadorBlue(){
		contaVezBlue += 1;
	}

	public void ReturnTheme(){
		AudioControllerGame.Instance.PlaySound (SoundGames.ButtonSound);
		Instantiate (ChooseTheme, ChooseTheme.transform.position, ChooseTheme.transform.rotation);
	}

	public void TVQuestionSet(){
		Instantiate (TVQuestion, TVQuestion.transform.position, TVQuestion.transform.rotation);
		AudioControllerGame.Instance.PlaySound (SoundGames.ButtonSound);
	}

	public void BordaoQuestionSet(){
		
		Instantiate (BordaoQuestion, BordaoQuestion.transform.position, BordaoQuestion.transform.rotation);
		AudioControllerGame.Instance.PlaySound (SoundGames.ButtonSound);

	}

	public void FilmeQuestionSet(){

		Instantiate (FilmeQuestion, FilmeQuestion.transform.position, FilmeQuestion.transform.rotation);	

	}

	public void RadioQuestionSet(){

		Instantiate (RadioQuestion, RadioQuestion.transform.position, RadioQuestion.transform.rotation);	

	}

	public void MusicaQuestionSet(){

		Instantiate (MusicaQuestion, MusicaQuestion.transform.position, MusicaQuestion.transform.rotation);	

	}

	public void SetUmGrupo(){
		umGrupo.SetActive (true);
	}

	public void SetGrupoVS(){
		GrupoVS.SetActive (true);
	}

	public void ReturnMainMenu(){
		SceneManager.LoadScene (0);
	}

	public void QuitGame(){
		Application.Quit ();
	}

		

}
