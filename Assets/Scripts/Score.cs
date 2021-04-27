using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score;
    public Text scoreDisplay;

    public GameObject spawner;
    public GameObject proceedButton;
    private void Update()
    {
 
        scoreDisplay.text = score.ToString();
        if(score == 0){
            spawner.SetActive(false);
            proceedButton.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(score); //1
        score--; //2
        Destroy(other.gameObject);

    }
}
