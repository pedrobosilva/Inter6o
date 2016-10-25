using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	public AudioClip soundPlay;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	public void PaySound () {
		if (!audioSource.isPlaying) {
			audioSource.PlayOneShot (soundPlay);
		} else {
			return;
		}
	}
}
