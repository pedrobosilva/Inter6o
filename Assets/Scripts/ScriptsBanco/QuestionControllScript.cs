using UnityEngine;
using System.Collections;

public class QuestionControllScript : MonoBehaviour {

	public static QuestionControllScript Instance;

	public GameObject perguntaImagem;
	public GameObject pergunta;
	public GameObject resposta0;
	public GameObject resposta1;
	public GameObject resposta2;
	public GameObject resposta3;
	public GameObject curiosidade0;
	public GameObject curiosidade1;
	public GameObject curiosidade2;
	public GameObject curiosidade3;

	public PerguntasClass.Temas TemaEscolhido;

	private int[] randomControll = {0,1,2,3};

	public Material[] Materiais;


	private int perguntaInicial = 0;

	void Start(){

		GameControl.gControl.perguntasList.Add(
			new PerguntasClass(
				"Emerson Fittipaldi foi em 1972:",
				PerguntasClass.Temas.Esporte,
				Materiais [0],
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


		GameControl.gControl.perguntasList.Add (
			new PerguntasClass (
				"Quem Protagonizou o filme Três Homens em Conflito?",
				PerguntasClass.Temas.Cinema,
				Materiais[1],
				"Clint Eastwood",
				"Curiosidade1",
				"Lee Van Cleef",
				"Curiosidade2",
				"Willian Holder",
				"Curiosidades3",
				"Marlon Brando",
				"Curiosidade4",
				"Alpatino",
				"Curiosidade5",
				"Sean Coorney",
				"Curiosidade6"));

		//GameControl.gControl.perguntasList [1].respostasBd [2].correta = true;



	}
	// Use this for initialization
	void Awake () {
		Instance = this;
	}
		
	
	// Update is called once per frame
	void Update () {

	
	}

	public void SetQuestion(){

		int randomNumber;
		//for(PerguntasClass.Temas i = null; i != TemaEscolhido; i = GameControl.gControl.perguntasList[Random.Range(perguntaInicial,GameControl.gControl.perguntasList.Count)].tema)
		do {
			
			randomNumber = UnityEngine.Random.Range (perguntaInicial, GameControl.gControl.perguntasList.Count);

		} while(GameControl.gControl.perguntasList [randomNumber].tema != TemaEscolhido);


			pergunta.GetComponent<ButtonScript> ().QuestionText.text = GameControl.gControl.perguntasList [randomNumber].textoDaPerguntaBd; 
			perguntaImagem.GetComponent<MeshRenderer> ().material = GameControl.gControl.perguntasList [randomNumber].materialImagem;

		for (int i = 0; i < 4; i++) {
			randomControll [i] = i;
		}

		resposta0.GetComponent<ButtonScript> ().AnswerText.text = null;
		resposta1.GetComponent<ButtonScript> ().AnswerText.text = null;
		resposta2.GetComponent<ButtonScript> ().AnswerText.text = null;
		resposta3.GetComponent<ButtonScript> ().AnswerText.text = null;

		int randomAnswer;


		if (resposta0.GetComponent<ButtonScript> ().AnswerText.text == "") {
			
			do {
				randomAnswer = randomControll [Random.Range (0, 4)];
			} while(randomAnswer == -1);
					
			resposta0.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].textoDaResposta;
			curiosidade0.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].curiosidade;
			if (randomAnswer == 0) {
				resposta0.GetComponent<ButtonScript> ().isCorrect = true;
			}
			for (int i = 0; i < 4; i++) {
				if (randomControll [i] == randomAnswer) {
					randomControll [i] = -1;
					break;
				}
			}
		}


		if (resposta1.GetComponent<ButtonScript> ().AnswerText.text == "") {

			do {
				randomAnswer = randomControll [Random.Range (0, 4)];
			} while(randomAnswer == -1);

			resposta1.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].textoDaResposta;
			curiosidade1.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].curiosidade;
			if (randomAnswer == 0) {
				resposta1.GetComponent<ButtonScript> ().isCorrect = true;
			}
			for (int i = 0; i < 4; i++) {
				if (randomControll [i] == randomAnswer) {
					randomControll [i] = -1;
					break;
				}
			}
		}
		if (resposta2.GetComponent<ButtonScript> ().AnswerText.text == "") {
			
			do {
				randomAnswer = randomControll [Random.Range (0, 4)];
			} while(randomAnswer == -1);

			resposta2.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].textoDaResposta;
			curiosidade2.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].curiosidade;
			if (randomAnswer == 0) {
				resposta2.GetComponent<ButtonScript> ().isCorrect = true;
			}
			for (int i = 0; i < 4; i++) {
				if (randomControll [i] == randomAnswer) {
					randomControll [i] = -1;
					break;
				}
			}
		}

		if (resposta3.GetComponent<ButtonScript> ().AnswerText.text == "") {
			
			do {
				randomAnswer = randomControll [Random.Range (0, 4)];
			} while(randomAnswer == -1);

			resposta3.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].textoDaResposta;
			curiosidade3.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [randomAnswer].curiosidade;
			if (randomAnswer == 0) {
				resposta3.GetComponent<ButtonScript> ().isCorrect = true;
			}
			for (int i = 0; i < 4; i++) {
				if (randomControll [i] == randomAnswer) {
					randomControll [i] = -1;
					break;
				}
			}
		}

			
			/*resposta1.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [1].textoDaResposta;
			resposta2.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [2].textoDaResposta;
			resposta3.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [3].textoDaResposta;

			
			curiosidade1.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [1].curiosidade;
			curiosidade2.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [2].curiosidade;
			curiosidade3.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [3].curiosidade;*/

	}



}
		


