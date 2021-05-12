using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyMusicLvl4.Instance.gameObject.GetComponent<AudioSource>().Pause();
        
        
    }
}