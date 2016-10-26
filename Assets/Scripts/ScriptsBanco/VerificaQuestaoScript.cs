using UnityEngine;
using System.Collections;

public class VerificaQuestaoScript : MonoBehaviour {

	public GameObject Curiosidade0;
	public GameObject Curiosidade1;
	public GameObject Curiosidade2;
	public GameObject Curiosidade3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colision){
		if (colision.name == "Resposta0") {
			Curiosidade0.SetActive (true);
			ButtonScript.Instance.CuriosidadeText.text = GameControl.gControl.perguntasList [1].respostasBd [0].curiosidade;
		}
			
			if (colision.name == "Resposta1") {
			Curiosidade1.SetActive (true);
			ButtonScript.Instance.CuriosidadeText.text = GameControl.gControl.perguntasList [1].respostasBd [1].curiosidade;
			}
	
			if (colision.name == "Resposta2") {
			Curiosidade2.SetActive (true);
			ButtonScript.Instance.CuriosidadeText.text = GameControl.gControl.perguntasList [1].respostasBd [2].curiosidade;
			}

			if (colision.name == "Resposta3") {
			Curiosidade3.SetActive (true);
			ButtonScript.Instance.CuriosidadeText.text = GameControl.gControl.perguntasList [1].respostasBd [3].curiosidade;
			}
	}
}
