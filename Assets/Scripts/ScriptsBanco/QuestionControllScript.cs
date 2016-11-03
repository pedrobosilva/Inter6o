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

	private int perguntaInicial = 0;

	void Start(){

		GameControl.gControl.perguntasList.Add(
			new PerguntasClass(
				"Emerson Fittipaldi foi em 1972:",
				PerguntasClass.Temas.Esporte,
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
				"William Holden",
				"Curiosidade1",
				"Lee Van Cleef",
				"Curiosidade2",
				"Clint Eastwood",
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
		

		int randomNumber = UnityEngine.Random.Range (perguntaInicial,GameControl.gControl.perguntasList.Count);


		pergunta.GetComponent<ButtonScript> ().QuestionText.text = GameControl.gControl.perguntasList [randomNumber].textoDaPerguntaBd; 

		resposta0.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [0].textoDaResposta;
		resposta1.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [1].textoDaResposta;
		resposta2.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [2].textoDaResposta;
		resposta3.GetComponent<ButtonScript> ().AnswerText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [3].textoDaResposta;

		curiosidade0.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [0].curiosidade;
		curiosidade1.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [1].curiosidade;
		curiosidade2.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [2].curiosidade;
		curiosidade3.GetComponent<ButtonScript> ().CuriosidadeText.text = GameControl.gControl.perguntasList [randomNumber].respostasBd [3].curiosidade;

	}


}
		


