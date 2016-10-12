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
	public int pontos;
	public int funFactor;


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

[Serializable]
public class PerguntasClass : MonoBehaviour {

	public string textoDaPerguntaBd;
	public Sprite dica;
	public AudioSource audioDaQuestao;
	public List<RespostasClass> respostasBd = new List<RespostasClass>();
	public int frequencia;
	public int rating;
	public enum Temas {Musica,Futebol,Radio,Arte,Outro};
	public Temas tema; 


	public PerguntasClass(string TextoDaPergunta,
		Temas TemaDaQuestao,
		string Resposta1Certa,
		string Curiosidade1,
		string Resposta2,
		string Curiosidade2,
		string Resposta3,
		string Curiosidade3,
		string Resposta4,
		string Curiosidade4,
		string Resposta5,
		string Curiosidade5,
		string Resposta6,
		string Curiosidade6,
		Sprite Dica = null,
		AudioSource AudioDaQuestao = null)
	{
		textoDaPerguntaBd = TextoDaPergunta;
		tema = TemaDaQuestao;
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta1Certa,Curiosidade1,true));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta2,Curiosidade2));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta3,Curiosidade3));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta4,Curiosidade4));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta5,Curiosidade5));
		respostasBd.Add (new RespostasClass (RespostasClass.Estados.Normal,Resposta6,Curiosidade6));
		audioDaQuestao = AudioDaQuestao;
		dica = Dica;

	}
}
[Serializable]
public class RespostasClass : MonoBehaviour {

	public Button clicavel;
	public enum Estados{Normal,Tentado,Curioso,CuriosoPronto,CertoPronto,Certo};
	public Estados estado;
	public string textoDaResposta;
	public string curiosidade;
	public bool correta;


	public RespostasClass(Estados Estado, string TextoDaResposta, string Curiosidade, Button botao = null)
	{
		estado = Estado;
		textoDaResposta = TextoDaResposta;
		curiosidade = Curiosidade;
		clicavel = botao;
	}
	public RespostasClass(Estados Estado, string TextoDaResposta, string Curiosidade,bool Correta, Button botao = null)
	{
		estado = Estado;
		textoDaResposta = TextoDaResposta;
		curiosidade = Curiosidade;
		correta = Correta;
		clicavel = botao;
	}
}


