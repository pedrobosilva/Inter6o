using UnityEngine;
using System.Collections;

public class PainelErrado : MonoBehaviour {

	public GameObject erradoPainel;
	public GameObject buttonErrado;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PainelSet(){
		erradoPainel.SetActive (true);
		AudioControllerGame.Instance.PlaySound (SoundGames.ButtonSound);
	}

	public void FechaPainel(){
		buttonErrado.SetActive (false);
		AudioControllerGame.Instance.PlaySound (SoundGames.ButtonSound);
		erradoPainel.SetActive (false);
	}

}
