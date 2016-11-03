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

	public GameObject backGroundZoom;

	public int respostanum;

	private bool isTapped = false;
	private bool isClosed = false;

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

		posicaoInitial = new Vector3 (transform.position.x, transform.position.y, -7);

	

	}

	private void OnEnable()
	{
		
			GetComponent<TapGesture> ().Tapped += TapAction;
	
		
		

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
		
		//AnswerText.text = GameControl.gControl.perguntasList [0].textoDaPerguntaBd;
	
		if (tipo == type.pergunta) {

			QuestionText.text = GameControl.gControl.perguntasList [1].textoDaPerguntaBd;
		}

		if (tipo == type.resposta) {

			AnswerText.text = GameControl.gControl.perguntasList [1].respostasBd [respostanum].textoDaResposta;
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
		

		transform.position = posicaoInitial;
	}

	void Update ()
	{


		transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, .1f);
	}

	private void TapAction(object sender, EventArgs e)
	{

		if (tipo == type.resposta) {
			backGroundZoom.SetActive (true);
			transform.position = new Vector3 (1.95f, 1.53f, -8.61f);
		} else {
			return;
		}
	}

	private void TapClosed(object sender, EventArgs e){

	}


}
