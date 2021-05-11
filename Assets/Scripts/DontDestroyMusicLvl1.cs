using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusicLvl1 : MonoBehaviour
{
    private static DontDestroyMusicLvl1 instance = null;
    public static DontDestroyMusicLvl1 Instance
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