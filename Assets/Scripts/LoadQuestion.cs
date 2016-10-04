using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class LoadQuestion : MonoBehaviour {

	public GameObject ChooseQuestionCanvas;
	public GameObject FutQuestion;
	public Transform CanvasParent;
	public GameObject ChooseTheme;

	public GameObject CuriosidadeCanvas;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ReturnTheme(){
		Instantiate (ChooseTheme, ChooseTheme.transform.position, ChooseTheme.transform.rotation);
	}

	public void EsporteQuestion(){
		Instantiate (FutQuestion, FutQuestion.transform.position, FutQuestion.transform.rotation);	

	}
		

}
