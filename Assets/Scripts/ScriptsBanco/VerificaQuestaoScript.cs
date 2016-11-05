using UnityEngine;
using System.Collections;

public class VerificaQuestaoScript : MonoBehaviour {

	public GameObject CanvasCuriosidade;

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
			Debug.Log (colision.gameObject.GetComponent<ButtonScript> ().isCorrect);
			Curiosidade0.SetActive (true);
			CanvasCuriosidade.SetActive (true);

		}
			
			if (colision.name == "Resposta1") {
			Debug.Log (colision.gameObject.GetComponent<ButtonScript> ().isCorrect);
			Curiosidade1.SetActive (true);
			CanvasCuriosidade.SetActive (true);
		
			}
	
			if (colision.name == "Resposta2") {
			Debug.Log (colision.gameObject.GetComponent<ButtonScript> ().isCorrect);
			Curiosidade2.SetActive (true);
			CanvasCuriosidade.SetActive (true);

			}

			if (colision.name == "Resposta3") {
			Debug.Log (colision.gameObject.GetComponent<ButtonScript> ().isCorrect);
			Curiosidade3.SetActive (true);
			CanvasCuriosidade.SetActive (true);

			}
	}
}
