using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TesteCria1Questao : MonoBehaviour {

	public GameObject pergunta;
	public Material[] testeImagem;


	// Use this for initialization
	void Start () {
		

	
	}

	// Update is called once per frame
	void Update () {
	}


	public void MostraBd()
	{
		for (int i = 0; i < GameControl.gControl.perguntasList.Count; i++) {
			Debug.Log (GameControl.gControl.perguntasList [i].textoDaPerguntaBd);
			for (int r = 0; r < GameControl.gControl.perguntasList [i].respostasBd.Count; r++) {
				Debug.Log (GameControl.gControl.perguntasList [i].respostasBd [r].textoDaResposta);
			}
		}
	}



	public void printaJSON()
	{
		Debug.Log(GeraJSON ());
	}

	public string GeraJSON()
	{
		return JsonUtility.ToJson (GameControl.gControl.perguntasList [0]);
	}

	public void CriaQuestao()
	{
		/*GameControl.gControl.perguntasList.Add(
			new PerguntasClass(
				"Emerson Fittipaldi foi em 1972:",
				PerguntasClass.Temas.Outro,
				testeImagem[0],
				"Campeão mundial mais jovem de F1 até então.",
				"Curiosidade1",
				"Primeiro e único campeão brasileiro de F1 da história.",
				"Curiosidade2",
				"Campeão das 500 milhas de Indianápolis.",
				"Curiosidade3",
				"Que encerrou sua carreira após um acidente no michigan speedway.",
				"Curiosidade4",
				"Presenciou o primeiro campeão póstumo de F1.",
				"Curiosidade5",
				"Venceu a corrida de Inauguração do autódromo de interlagos.",
				"Curiosidade6"));
		GameControl.gControl.perguntasList.Add(
			new PerguntasClass(
				"Titulo 2",
				PerguntasClass.Temas.Outro,
				testeImagem[1],
				"Campeão mundial mais jovem de F1 até então.",
				"Curiosidade1",
				"Primeiro e único campeão brasileiro de F1 da história.",
				"Curiosidade2",
				"Campeão das 500 milhas de Indianápolis.",
				"Curiosidade3",
				"Que encerrou sua carreira após um acidente no michigan speedway.",
				"Curiosidade4",
				"Presenciou o primeiro campeão póstumo de F1.",
				"Curiosidade5",
				"Venceu a corrida de Inauguração do autódromo de interlagos.",
				"Curiosidade6"));
				*/
		
		//Debug.Log(GameControl.gControl.perguntasList [0].respostasBd [2].textoDaResposta);
		//Debug.Log(GameControl.gControl.perguntasList [0].respostasBd [2].correta);

		GeradorDeArquivo geradorDeArquivo = new GeradorDeArquivo();

		geradorDeArquivo.SalvaPerguntas (GameControl.gControl.perguntasList);


	/*	pergunta = Instantiate (pergunta);
		perguntaClass.textoDaPerguntaBd = "Emerson Fittipaldi foi em 1972:";
		perguntaClass.respostasBd [0].textoDaResposta = "Primeiro e único campeão brasileiro de F1 da história.";
		perguntaClass.respostasBd [0].correta = false;
		perguntaClass.respostasBd [0].estado = RespostasClass.Estados.Normal;
		perguntaClass.respostasBd [1].textoDaResposta = "Campeão mundial mais jovem de F1 até então.";
		perguntaClass.respostasBd [1].correta = true;
		perguntaClass.respostasBd [1].estado = RespostasClass.Estados.Normal;
		perguntaClass.respostasBd [2].textoDaResposta = "Campeão das 500 milhas de Indianápolis.";
		perguntaClass.respostasBd [2].correta = false;
		perguntaClass.respostasBd [2].estado = RespostasClass.Estados.Normal;
		perguntaClass.respostasBd [3].textoDaResposta = "Que encerrou sua carreira após um acidente no michigan speedway.";
		perguntaClass.respostasBd [3].correta = false;
		perguntaClass.respostasBd [3].estado = RespostasClass.Estados.Normal;
		perguntaClass.respostasBd [4].textoDaResposta = "Presenciou o primeiro campeão póstumo de F1.";
		perguntaClass.respostasBd [4].correta = false;
		perguntaClass.respostasBd [4].estado = RespostasClass.Estados.Normal;
		perguntaClass.respostasBd [5].textoDaResposta = "Venceu a corrida de Inauguração do autódromo de interlagos.";
		perguntaClass.respostasBd [5].correta = false;
		perguntaClass.respostasBd [5].estado = RespostasClass.Estados.Normal;

		GameControl.gControl.perguntasBd [0]= pergunta;*/


	}
}
