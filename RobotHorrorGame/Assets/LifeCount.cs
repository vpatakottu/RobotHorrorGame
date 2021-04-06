using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCount : MonoBehaviour
{
    public int playerLives; 
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
