using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {

	public static ChangeMaterial Instance;
	public Material materialParede;
	public Material blackMaterial;

	void Awake(){
		Instance = this;
	}

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		/*if (FogScript.Instance.usandoPedra == true) {
			gameObject.GetComponent<MeshRenderer> ().material = materialParede;
		} else {
			gameObject.GetComponent<MeshRenderer> ().material = blackMaterial;
		}
	*/
	}
}
