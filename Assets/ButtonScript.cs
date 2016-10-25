using System;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public bool isCorrect = false;
	public Text AnswerText;
	public Text QuestionText;
	public enum type{pergunta,resposta}
	public type tipo; 
	public float tilt;
	private Rigidbody rb;
	private Vector3 velocity = Vector3.zero;
	private Vector3 laterPos;

	private Quaternion targetRotation;

	private void Awake()
	{
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
		Debug.Log (GameControl.gControl.perguntasList [0].respostasBd [0].textoDaResposta);

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


	private	void PanStartAction(object sender, EventArgs e)
	{
		Debug.Log ("PanStart");
	}

	private void PanWhileAction(object sender, EventArgs e)
	{
		Debug.Log ("PanWhile");
	}

	private void PanCompleteAction(object sender, EventArgs e)
	{
		Debug.Log ("CompletePan");
	}

	void Update ()
	{

		transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, .1f);
	}

	private void TapAction(object sender, EventArgs e)
	{
		Debug.Log ("TAPPED");
		targetRotation = Quaternion.Euler(180, 0, 0) * targetRotation;

		AnswerText.text = GameControl.gControl.perguntasList [0].textoDaPerguntaBd;
	}
}
