using UnityEngine;
using System.Collections;

public enum SoundGames{
	ButtonSound,
	RespostaCorretaSound,
	MoedaSound,
	RespostaErradaSound
}

public class AudioControllerGame : MonoBehaviour {
	public static AudioControllerGame Instance;

	public AudioSource audioSource;

	public AudioClip buttonSound;
	public AudioClip respostaCorreta;
	public AudioClip moedaSound;
	public AudioClip respostaErradaSound;

	void Awake(){
		Instance = this;
	}

	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	public void PlaySound(SoundGames soundID){
		switch (soundID) {
		case SoundGames.ButtonSound: 
			audioSource.PlayOneShot (buttonSound);
			break;
		}

		switch (soundID) {
		case SoundGames.RespostaCorretaSound: 
			audioSource.PlayOneShot (respostaCorreta);
			break;
		}

		switch (soundID) {
		case SoundGames.MoedaSound: 
			audioSource.PlayOneShot (moedaSound);
			break;
		}

		switch (soundID) {
		case SoundGames.RespostaErradaSound: 
			audioSource.PlayOneShot (respostaErradaSound);
			break;
		}
	}
}
