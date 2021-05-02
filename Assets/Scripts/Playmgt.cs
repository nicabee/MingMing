using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Playmgt : MonoBehaviour {

	public Animator Anim;
	public float transitionTime = 1f;    
	public void NextGame(){
		Debug.Log("Clicked4");
	//	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		StartCoroutine(Fade());
	}

	IEnumerator Fade(){
		Anim.SetTrigger("Start");
		yield return new WaitForSeconds(transitionTime);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
}