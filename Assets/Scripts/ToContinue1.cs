using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToContinue1 : MonoBehaviour {

	private int sceneToContinue;

	public void ContinueGame(){
		sceneToContinue = PlayerPrefs.GetInt("SavedScene");

		if (sceneToContinue != 0){
			SceneManager.LoadScene(sceneToContinue);
          //  Debug.Log(sceneToContinue);
           if(sceneToContinue == 7){
                DontDestroyMusicLvl1.Instance.gameObject.GetComponent<AudioSource>().Play();
            }else if (sceneToContinue == 10){
                DontDestroyMusicLvl2.Instance.gameObject.GetComponent<AudioSource>().Play();
            }else if (sceneToContinue == 13){
                DontDestroyMusicLvl3.Instance.gameObject.GetComponent<AudioSource>().Play();
            }else if (sceneToContinue == 16){
                DontDestroyMusicLvl4.Instance.gameObject.GetComponent<AudioSource>().Play();
            }else if (sceneToContinue == 19){
                DontDestroyMusicLvl5.Instance.gameObject.GetComponent<AudioSource>().Play();
            }
                
       
            
		}else{
			return;
		}
	}
}
