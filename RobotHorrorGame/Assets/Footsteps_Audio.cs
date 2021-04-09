using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps_Audio : MonoBehaviour
{
    CharacterController player;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("left") || Input.GetKeyDown("right") || Input.GetKeyDown("up") || Input.GetKeyDown("down"))
        //{

        //    audioSource.volume = Random.Range(0.8f, 1);
        //    audioSource.pitch = Random.Range(0.8f, 1.1f);
        //    audioSource.Play();
        //}
        Debug.Log(player.velocity.magnitude);
        if (player.isGrounded && (Input.GetKeyDown("left") || Input.GetKeyDown("right") || Input.GetKeyDown("up") || Input.GetKeyDown("down")) &&  audioSource.isPlaying == false)
        {
            Debug.Log("Made it here");
            audioSource.volume = Random.Range(0.8f, 1);
            audioSource.pitch = Random.Range(0.8f, 1.1f);
            audioSource.Play();
            Debug.Log("You should hear a footstep");
        }
    }
}
//player.velocity.magnitude > 0f
