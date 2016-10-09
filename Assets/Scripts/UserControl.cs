using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class UserControl : MonoBehaviour {

	public float experience;
	public static UserControl userInstace;


	void Awake () {
		
		if (userInstace == null) {
			DontDestroyOnLoad (gameObject);
			userInstace = this;
		} else if (userInstace != this) {
			Destroy (gameObject);
		}
	}

	public void SaveUserData()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.dataPath + "/userData.dat");

		UserData uData = new UserData ();
		uData.experience = experience;

		bf.Serialize (file, uData);
		file.Close ();
	}
	public void LoadUserData()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Open (Application.dataPath + "/userData.dat",FileMode.Open);

		UserData uData = (UserData)bf.Deserialize (file);
		file.Close ();

		experience = uData.experience;



	}


}

[Serializable]
class UserData
{
	public float experience;
}
