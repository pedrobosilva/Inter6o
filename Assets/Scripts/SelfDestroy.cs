using UnityEngine;
using System.Collections;

public class SelfDestroy : MonoBehaviour {

	private bool isOn = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (isOn);
		if (isOn) {
			isOn = false;
			Destroy (gameObject);

		}
	}

	public void SelfDestroyFunction(){
		isOn = true;
	}
}
