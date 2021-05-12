using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyMusicLvl6.Instance.gameObject.GetComponent<AudioSource>().Pause();
        
        
    }
}