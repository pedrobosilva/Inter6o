using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class GameControl : MonoBehaviour {


	public static GameControl gControl;
	public GameObject[] perguntasBdGo;
	public List<PerguntasClass> perguntasList = new List<PerguntasClass> ();
	public int pontos = 0;
	public int funFactor = 8;



	void Awake () {
		
		if (gControl == null) {
			DontDestroyOnLoad (gameObject);
			gControl = this;
		} else if (gControl != this) {
			Destroy (gameObject);
		}
	}



	void Start()
	{
	//	LoadUserData ();
	//	LoadQuestionData ();

	}

	//Saves de Usuário
	public void SaveUserData()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.dataPath + "/userData.dat");

		UserData uData = new UserData ();
		uData.pontos = pontos;
		uData.funFactor = funFactor;

		bf.Serialize (file, uData);
		file.Close ();
	}
	public void LoadUserData()
	{

		if (File.Exists(Application.dataPath + "/userData.dat")) {

			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.dataPath + "/userData.dat",FileMode.Open);

			UserData uData = (UserData)bf.Deserialize (file);
			file.Close ();

			pontos = uData.pontos;
			funFactor = uData.funFactor;
			Debug.Log ("LoadUserData OK");

		}
		else {
			Debug.Log ("LoadUserData FAIL");
			return;
		}

	}

	//Saves de Banco de dados de Questões
	public void SaveQuestionData()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.dataPath + "/questionData.dat");

	//	QuestionData qData = new QuestionData ();
	//	qData.perguntasBd = perguntasList;

	//	bf.Serialize (file, qData);
		file.Close ();
	}
	public void LoadQuestionData()
	{
		if (File.Exists(Application.dataPath + "/questionData.dat")){
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.dataPath + "/questionData.dat",FileMode.Open);

			QuestionData qData = (QuestionData)bf.Deserialize (file);
			file.Close ();

	//		perguntasList = qData.perguntasBd;
			Debug.Log ("LoadQuestionData OK");
		}
		else {
			Debug.Log ("LoadQestionData FAIL");
		}

	}

}

[Serializable]
class UserData
{
	public int pontos;
	public int funFactor;
}

[Serializable]
class QuestionData
{
	public PerguntasClass[] perguntasBd;

	public QuestionData(int TamanhoDaLista, List<PerguntasClass> Lista)
	{
		perguntasBd = new PerguntasClass[TamanhoDaLista];
		for (int i = 0; i < TamanhoDaLista; i++) {
			perguntasBd [i] = Lista [i];
		}
	}
}

class QuestionDataLoad
{
	public PerguntasClass[] perguntasBd;
	public List<PerguntasClass> perguntasLista;
}



