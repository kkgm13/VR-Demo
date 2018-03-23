using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Load the Next Intended Scene
	public void loadScene(string sceneName){
		SceneManager.LoadScene (sceneName);
	}

	public void quit(){
		Application.Quit();
	}

}
