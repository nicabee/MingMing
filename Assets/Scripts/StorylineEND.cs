using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StorylineEND : MonoBehaviour {

	public Text textDisplay;
	public string[] sentences;
	private int index;
	public float typingSpeed;

	public GameObject continueButton;
	//public GameObject playButton;


	public Animator Anim;
	public float transitionTime = 1f;  
	void Start(){
		StartCoroutine(Type());
	}

	void Update(){
		if(textDisplay.text == sentences [index]){
			continueButton.SetActive(true);
		}
	}

	IEnumerator Type(){
		foreach(char letter in sentences[index].ToCharArray()){
			textDisplay.text += letter;
			yield return new WaitForSeconds(typingSpeed);
		}
	}

	public void NextSentence(){

		continueButton.SetActive(false);

		if(index < sentences.Length - 1){
			index++;
			textDisplay.text = "";
			StartCoroutine(Type());
		}else{
			textDisplay.text = "";
			continueButton.SetActive(false);
			StartCoroutine(Fade());
		//	playButton.SetActive(true);
		}
	}

	IEnumerator Fade(){
		Anim.SetTrigger("Start");
		yield return new WaitForSeconds(transitionTime);
		SceneManager.LoadScene("MainMenu");
	}
	// public void PlayGame(){
	// 	Debug.Log("Clicked3");
	// 	StartCoroutine(Fade());
	// 	//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	// }
}
