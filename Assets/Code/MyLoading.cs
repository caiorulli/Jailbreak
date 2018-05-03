using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyLoading : MonoBehaviour {
	static string nextScene;

	public static string NextScene
	{
		get 
		{
			return nextScene;
		}

		set
		{
			nextScene = value;
		}
	}


	void Start () {
		SceneManager.LoadScene(NextScene);
	}
	
	void Update () {
		
	}
}
