using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyMusicLvl2.Instance.gameObject.GetComponent<AudioSource>().Pause();
        
        
    }
}