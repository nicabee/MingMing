using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyMusicLvl1.Instance.gameObject.GetComponent<AudioSource>().Pause();
        
        
    }
}