using UnityEngine;
using System.Collections;

public class GrupoVSGrupoController : MonoBehaviour {

	public static GrupoVSGrupoController Instance;

	public bool vezBlue = false;
	public bool vezRed = false;

	public GameObject blueCanvas;
	public GameObject redCanvas;

	public GameObject questionTVCanvas;
	public GameObject bordaoTVCanvas;

	public int randomVez;

	public int contaVezRed;	
	public int contaVezBlue;

	// Use this for initialization
	void Awake () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetTVQuestion(){
		Instantiate (questionTVCanvas, questionTVCanvas.transform.position, questionTVCanvas.transform.rotation);
		AudioControllerGame.Instance.PlaySound (SoundGames.ButtonSound);
		
	}

	public void SetBordaoQuestion(){
		Instantiate (bordaoTVCanvas, bordaoTVCanvas.transform.position, bordaoTVCanvas.transform.rotation);
		AudioControllerGame.Instance.PlaySound (SoundGames.ButtonSound);

	}

	public void VerificaTeam(){
		
	}

	public void SetBlueTeam(){
		blueCanvas.SetActive (true);
		contaVezBlue += 1;
	}

	public void SetRedTeam(){
		redCanvas.SetActive (true);
		contaVezRed += 1;
	}

	public void RandomEquipe(){
		randomVez = Random.Range (0, 2);

		if (randomVez == 0 && contaVezBlue <= 0) {
			SetBlueTeam ();
		} 

		if (randomVez == 1 && contaVezRed <= 0) {
			SetRedTeam ();
		}
	}
		
}
