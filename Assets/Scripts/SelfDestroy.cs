using UnityEngine;
using System.Collections;

public class SelfDestroy : MonoBehaviour {

	public static SelfDestroy Instance;

	private bool isOn = false;
	public bool isDisable = false;

	// Use this for initialization
	void Awake () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {

		if (isOn) {
			isOn = false;
			Destroy (gameObject);

		}
			
	}

	public void SelfDestroyFunction(){
		isOn = true;
	}

	public void DisableObject(){
		gameObject.SetActive (false);
	}



}
