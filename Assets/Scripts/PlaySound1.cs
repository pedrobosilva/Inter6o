using UnityEngine;
using System.Collections;

public class PlaySound1 : MonoBehaviour {

	public GameObject objetoDoSom;

	public enum type {Curiosidade, Pergunta, Alternativas}
	public type tipo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void PlaySound(){
		if (tipo == type.Curiosidade && !objetoDoSom.GetComponent<ButtonScript>().audioSource.isPlaying) {
			objetoDoSom.GetComponent<ButtonScript> ().audioSource.PlayOneShot (objetoDoSom.GetComponent<ButtonScript> ().audioCuriosisidade);
		}

		if (tipo == type.Pergunta && !objetoDoSom.GetComponent<AudioSource>().isPlaying) {
			objetoDoSom.GetComponent<ButtonScript> ().audioSource.PlayOneShot (objetoDoSom.GetComponent<ButtonScript> ().audioDaPergunta);


		}

		if (tipo == type.Alternativas && !objetoDoSom.GetComponent<ButtonScript>().audioSource.isPlaying) {
			objetoDoSom.GetComponent<ButtonScript> ().audioSource.PlayOneShot (objetoDoSom.GetComponent<ButtonScript> ().audioDasAlternativas);

		}
	}

	public void StopSound(){
		objetoDoSom.GetComponent<ButtonScript> ().audioSource.Stop();
	}
}
