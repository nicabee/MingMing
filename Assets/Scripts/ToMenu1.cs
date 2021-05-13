using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ToMenu1 : MonoBehaviour {

	private int currentSceneIndex;


	public void LoadMainMenu(){
		
		currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        //Debug.Log(currentSceneIndex);
        if(currentSceneIndex == 7){
            DontDestroyMusicLvl1.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if (currentSceneIndex == 10){
            DontDestroyMusicLvl2.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if (currentSceneIndex == 13){
            DontDestroyMusicLvl3.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if (currentSceneIndex == 16){
            DontDestroyMusicLvl4.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if (currentSceneIndex == 19){
            DontDestroyMusicLvl5.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }

		SceneManager.LoadScene(0);
	}
}
