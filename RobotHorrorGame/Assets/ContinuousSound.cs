using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousSound : MonoBehaviour
{
    private static ContinuousSound instance = null;
    public static ContinuousSound Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
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