using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Animator Anim;
//	public Image Img;
	public float transitionTime = 1f;
	public void PlayGame(){
		Debug.Log("Clicked2");
	//	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		StartCoroutine(Fade());
	}

	IEnumerator Fade(){
		Anim.SetTrigger("Start");
		yield return new WaitForSeconds(transitionTime);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
	public void QuitGame(){
		Debug.Log("Quit!");
		Application.Quit();
	}
}
