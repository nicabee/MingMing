using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour {

    public int score;
    public Text scoreDisplay;

    public GameObject spawner;
    public GameObject proceedButton;
    private void Update()
    {
 
        scoreDisplay.text = score.ToString();
        if(score <= 0){
            
            proceedButton.SetActive(true);
            Destroy(gameObject);
        }else if (score <= 4){
            spawner.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(score); //1
        if(score >= 1){
            score--; //2
        }
        
        Destroy(other.gameObject);

    }
}
