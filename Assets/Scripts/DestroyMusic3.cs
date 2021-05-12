using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyMusicLvl3.Instance.gameObject.GetComponent<AudioSource>().Pause();
        
        
    }
}