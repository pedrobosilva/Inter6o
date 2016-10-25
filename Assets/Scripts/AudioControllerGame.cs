using UnityEngine;
using System.Collections;

public enum SoundGames{
	ButtonSound
}

public class AudioControllerGame : MonoBehaviour {
	public static AudioControllerGame Instance;

	public AudioSource audioSource;

	public AudioClip buttonSound;

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
	}
}
