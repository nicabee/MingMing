using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusicLvl2 : MonoBehaviour
{
    private static DontDestroyMusicLvl2 instance = null;
    public static DontDestroyMusicLvl2 Instance
    {
        get {return instance; }
    }

    // Update is called once per frame
    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}