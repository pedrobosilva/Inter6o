using UnityEngine;
using System.Collections;

public class CuriosidadePergunta1 : MonoBehaviour {

	public GameObject CuriosidadeCanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CuriosidadeOpen(){
		AudioControllerGame.Instance.PlaySound (SoundGames.ButtonSound);
		Instantiate (CuriosidadeCanvas, CuriosidadeCanvas.transform.position, CuriosidadeCanvas.transform.rotation);
	}
}
