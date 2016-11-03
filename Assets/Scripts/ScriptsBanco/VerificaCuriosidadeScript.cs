using UnityEngine;
using System.Collections;

public class VerificaCuriosidadeScript : MonoBehaviour {

	public GameObject CanvasCuriosidade;

	public GameObject Curiosidade0;
	public GameObject Curiosidade1;
	public GameObject Curiosidade2;
	public GameObject Curiosidade3;

	private Vector3 initialCuriosidade0;
	private Vector3 initialCuriosidade1;
	private Vector3 initialCuriosidade2;
	private Vector3 initialCuriosidade3;



	// Use this for initialization
	void Start () {

		initialCuriosidade0 = new Vector3 (Curiosidade0.transform.position.x, Curiosidade0.transform.position.y, Curiosidade0.transform.position.z);
		initialCuriosidade1 = new Vector3 (Curiosidade1.transform.position.x, Curiosidade1.transform.position.y, Curiosidade1.transform.position.z);
		initialCuriosidade2 = new Vector3 (Curiosidade2.transform.position.x, Curiosidade2.transform.position.y, Curiosidade2.transform.position.z);
		initialCuriosidade3 = new Vector3 (Curiosidade3.transform.position.x, Curiosidade3.transform.position.y, Curiosidade3.transform.position.z);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colision){
		if (colision.name == "Curiosidade0") {
			Curiosidade0.transform.position = initialCuriosidade0;
			Curiosidade0.SetActive (false);
			CanvasCuriosidade.SetActive (false);
		}

		if (colision.name == "Curiosidade1") {
			Curiosidade1.transform.position = initialCuriosidade1;
			Curiosidade1.SetActive (false);
			CanvasCuriosidade.SetActive (false);
		}

		if (colision.name == "Curiosidade2") {
			Curiosidade2.transform.position = initialCuriosidade2;
			Curiosidade2.SetActive (false);
			CanvasCuriosidade.SetActive (false);
		}

		if (colision.name == "Curiosidade3") {
			Curiosidade3.transform.position = initialCuriosidade3;
			Curiosidade3.SetActive (false);
			CanvasCuriosidade.SetActive (false);
		}
	}
}
