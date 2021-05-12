using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyMusicLvl5.Instance.gameObject.GetComponent<AudioSource>().Pause();
        
        
    }
}