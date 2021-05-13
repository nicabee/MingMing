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
            if(sceneToContinue == 3 || sceneToContinue == 4){
                DontDestroyMusic.Instance.gameObject.GetComponent<AudioSource>().Play();
            }
            else if(sceneToContinue == 5 || sceneToContinue == 6 || sceneToContinue == 7 || sceneToContinue == 8){
                DontDestroyMusicLvl1.Instance.gameObject.GetComponent<AudioSource>().Play();
            }else if (sceneToContinue == 9 || sceneToContinue == 10 || sceneToContinue == 11){
                DontDestroyMusicLvl2.Instance.gameObject.GetComponent<AudioSource>().Play();
            }else if (sceneToContinue == 12 || sceneToContinue == 13 || sceneToContinue == 14){
                DontDestroyMusicLvl3.Instance.gameObject.GetComponent<AudioSource>().Play();
            }else if (sceneToContinue == 15 || sceneToContinue == 16 || sceneToContinue == 17){
                DontDestroyMusicLvl4.Instance.gameObject.GetComponent<AudioSource>().Play();
            }else if (sceneToContinue == 18 || sceneToContinue == 19 || sceneToContinue == 20){
                DontDestroyMusicLvl5.Instance.gameObject.GetComponent<AudioSource>().Play();
            }else if (sceneToContinue == 21 || sceneToContinue == 22 ){
            DontDestroyMusicLvl6.Instance.gameObject.GetComponent<AudioSource>().Play();
            }
                
       
            
		}else{
			return;
		}
	}
}
