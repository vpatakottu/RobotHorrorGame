using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 15f;
    public float gravity = -9.81f;
    

    public Transform groundCheck;
    public float ground_distance = 0.4f;
    public LayerMask groundMask;
    public Vector3 velocity;
    bool onGround;
    bool playerMoving;
    public AudioSource audioSource;
    public float footstepDelay;
    private float nextFootstep = 0;
    const float _timeBetweenFootsteps = 0.4f;
    float _lastPlayedFootstepSoundTime = -_timeBetweenFootsteps;



    // Update is called once per frame
    void Update()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        onGround = Physics.CheckSphere(groundCheck.position, ground_distance, groundMask);

        if (onGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 direction = transform.right * horiz + transform.forward * vert;

        controller.Move(direction * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey("left") || Input.GetKey("right")
          || Input.GetKey("up") || Input.GetKey("down"))
        {
            nextFootstep -= Time.deltaTime;
            if (nextFootstep <= 0)
            {
                if (Time.timeSinceLevelLoad - _lastPlayedFootstepSoundTime > _timeBetweenFootsteps)
                {
                    audioSource.volume = Random.Range(0.2f, 0.7f);
                    audioSource.pitch = Random.Range(0.6f, 1.1f);
                    audioSource.Play();
                    _lastPlayedFootstepSoundTime = Time.timeSinceLevelLoad;
                }
                //audioSource.Play();
                nextFootstep += footstepDelay;
                //if (controller.velocity.magnitude > 0f)
                //{

                //    if (!audioSource.isPlaying)
                //    {
                //        audioSource.Play();

                //    }
                //}
                //else
                //    audioSource.Stop();



                //    if (Input.GetKeyDown("left")|| Input.GetKeyDown("right")|| Input.GetKeyDown("up")|| Input.GetKeyDown("down"))
                //    {
                //        if (!audioSource.isPlaying)
                //        {
                //            audioSource.Play();
                //        }


                //    }
                //    if (Input.GetKeyUp("left") || Input.GetKeyUp("right") || Input.GetKeyUp("up") || Input.GetKeyUp("down"))//add if controller comes in contact with trigger, stop sound
                //    {
                //        audioSource.Stop();
                //    }

                //    //if (!GameObject.FindWithTag("Player").)
                //    //{
                //    //    audioSource.Stop();
                //    //}
                //}
                //void onTriggerEnter(Collider box)
                //{
                //    audioSource.Stop();
                //}
            }

        }
    }
}
