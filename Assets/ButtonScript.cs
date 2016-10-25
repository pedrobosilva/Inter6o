using System;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public static ButtonScript Instance;

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

	public int respostanum;

	private Quaternion targetRotation;

	private Vector3 posicaoInitial;
	private Vector3 scaleInitial;

	private void Awake()
	{
		Instance = this;

		targetRotation = transform.localRotation;
		rb = gameObject.GetComponent<Rigidbody> ();
	}

	void Start()
	{

		GameControl.gControl.perguntasList.Add(
			new PerguntasClass(
				"Emerson Fittipaldi foi em 1972:",
				PerguntasClass.Temas.Outro,
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
		//Debug.Log (GameControl.gControl.perguntasList [0].respostasBd [0].textoDaResposta);

		GameControl.gControl.perguntasList.Add (
			new PerguntasClass (
				"Quem Protagonizou o filme Três Homens em Conflito?",
				PerguntasClass.Temas.Outro,
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

		GameControl.gControl.perguntasList [1].respostasBd [2].correta = true;


		if (tipo == type.pergunta) {

			QuestionText.text = GameControl.gControl.perguntasList [1].textoDaPerguntaBd;
		}

		if (tipo == type.resposta) {

			AnswerText.text = GameControl.gControl.perguntasList [1].respostasBd [respostanum].textoDaResposta;
		}

		posicaoInitial = new Vector3 (transform.position.x, transform.position.y, -7);

	}

	private void OnEnable()
	{
		GetComponent<TapGesture>().Tapped += TapAction;

		GetComponent<PanGesture> ().PanStarted += PanStartAction;
		GetComponent<PanGesture> ().Panned += PanWhileAction;
		GetComponent<PanGesture> ().PanCompleted += PanCompleteAction;
	}

	private void OnDisable()
	{
		GetComponent<TapGesture>().Tapped -= TapAction;

		GetComponent<PanGesture> ().PanStarted -= PanStartAction;
		GetComponent<PanGesture> ().Panned -= PanWhileAction;
		GetComponent<PanGesture> ().PanCompleted -= PanCompleteAction;
	}


	void FixedUpdate()
	{
		
	}

	public void SetQuestion(){
		AnswerText.text = GameControl.gControl.perguntasList [0].textoDaPerguntaBd;
	}


	private	void PanStartAction(object sender, EventArgs e)
	{
		Debug.Log ("PanStart");
		transform.position = new Vector3(transform.position.x, transform.position.y, -7.1f);
	}

	private void PanWhileAction(object sender, EventArgs e)
	{
		Debug.Log ("PanWhile");
	}

	private void PanCompleteAction(object sender, EventArgs e)
	{
		Debug.Log ("CompletePan");

		transform.position = posicaoInitial;
	}

	void Update ()
	{

		transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, .1f);
	}

	private void TapAction(object sender, EventArgs e)
	{
		Debug.Log ("TAPPED");
		//transform.position = new Vector3 (-15.84f, -2.94f, -7);
		//targetRotation = Quaternion.Euler(180, 0, 0) * targetRotation;
	}
}
