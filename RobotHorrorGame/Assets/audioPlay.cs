using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    // Start is called before the first frame update
       
    public AudioClip playJoy;
    public AudioClip playSadness;
    public AudioClip playHate;
    public AudioSource audioSource;
   
   
    void Awake () {
       
        audioSource = GetComponent<AudioSource>();
    }
   
    void playJoySound() {
       
        audioSource.PlayOneShot(playJoy);
    }
    
    void playSadnessSound() {
        audioSource.PlayOneShot(playSadness);
    }

    void playHateSound() {
        audioSource.PlayOneShot(playHate);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}

