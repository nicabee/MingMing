using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusicLvl4 : MonoBehaviour
{
    private static DontDestroyMusicLvl4 instance = null;
    public static DontDestroyMusicLvl4 Instance
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