using UnityEngine;
using System.Collections;

public class SpintCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (5, 5, 0);
		gameObject.transform.Translate (0.05f, 0, 0);
	}
}
