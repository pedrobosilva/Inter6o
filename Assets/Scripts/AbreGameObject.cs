using UnityEngine;
using System.Collections;

public class AbreGameObject : MonoBehaviour {

	public GameObject objectToOpen;
	public GameObject objectToClose;

	public GameObject botaoToOpen;

	public GameObject ChooseTheme;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	public void AbrirEFecharGameObject () {
		objectToClose.SetActive (false);
		objectToOpen.SetActive (true);
	}

	public void DesabilitarObject(){
		objectToClose.SetActive (false);
	}

	public void AbrirObject(){
		objectToOpen.SetActive (true);
	}

	public void AbrirBotao(){
		botaoToOpen.SetActive (true);
	}

	public void FecharBotao(){
		botaoToOpen.SetActive (false);
	}


	public void ReturnTheme(){
		AudioControllerGame.Instance.PlaySound (SoundGames.ButtonSound);
		Instantiate (ChooseTheme, ChooseTheme.transform.position, ChooseTheme.transform.rotation);
	}

}
