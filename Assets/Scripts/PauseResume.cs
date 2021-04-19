﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour {

	public GameObject PauseScreen;

	bool GamePaused;
	// Use this for initialization
	void Start () {
		GamePaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(GamePaused){
			Time.timeScale = 0;
		}else{
			Time.timeScale = 1;
		}
	}

	public void PauseGame(){

		GamePaused = true;
		PauseScreen.SetActive(true);
	}

	public void ResumeGame(){

		GamePaused = false;
		PauseScreen.SetActive(false);
	}
}
