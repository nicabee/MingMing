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
        if(currentSceneIndex == 3 || currentSceneIndex == 4){
            DontDestroyMusic.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }
        else if(currentSceneIndex == 5 || currentSceneIndex == 6 || currentSceneIndex == 7 || currentSceneIndex == 8){
            DontDestroyMusicLvl1.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if (currentSceneIndex == 9 || currentSceneIndex == 10 || currentSceneIndex == 11){
            DontDestroyMusicLvl2.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if (currentSceneIndex == 12 || currentSceneIndex == 13 || currentSceneIndex == 14){
            DontDestroyMusicLvl3.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if (currentSceneIndex == 15 || currentSceneIndex == 16 || currentSceneIndex == 17){
            DontDestroyMusicLvl4.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if (currentSceneIndex == 18 || currentSceneIndex == 19 || currentSceneIndex == 20){
            DontDestroyMusicLvl5.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }else if (currentSceneIndex == 21 || currentSceneIndex == 22 ){
            DontDestroyMusicLvl6.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }

		SceneManager.LoadScene(0);
	}
}
