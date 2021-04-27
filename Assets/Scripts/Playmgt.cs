using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Playmgt : MonoBehaviour {

    public void NextGame(){
		Debug.Log("Clicked4");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
}