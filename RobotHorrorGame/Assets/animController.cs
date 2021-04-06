using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class animController : MonoBehaviour
{
    public Animator anim;
    public AudioSource phrase;

    public AudioClip hate2;
    public AudioClip sadness2;
    public AudioClip joy3;
    public AudioClip anger2;
    public AudioClip pride3;
    public AudioClip sadness4;
    public AudioClip shame3;
    public AudioClip regret4;

    // Start is called before the first frame update
    void Start()
    {
    anim = GetComponent<Animator>();   
    phrase = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1")) {
            phrase.clip = hate2;
            anim.Play("hate2");
            phrase.Play();
        }
        if (Input.GetKeyDown("2"))  {
            phrase.clip = sadness2;
            anim.Play("sadness2");
            phrase.Play();
        }
        if (Input.GetKeyDown("3")) {
            phrase.clip = joy3;
            anim.Play("joy3");
            phrase.Play();
        }
        if (Input.GetKeyDown("4")) {
            phrase.clip = anger2;
            anim.Play("anger2");
            phrase.Play();
        }
        if (Input.GetKeyDown("5")) {
            phrase.clip = pride3;
            anim.Play("pride3");
            phrase.Play();
        } 
        if (Input.GetKeyDown("6")) {
            phrase.clip = sadness4;
            anim.Play("sadness4");
            phrase.Play();
        }  
        if (Input.GetKeyDown("7")) {
            phrase.clip = shame3;
            anim.Play("shame3");
            phrase.Play();
        }
        if (Input.GetKeyDown("8")) {
            phrase.clip = regret4;
            anim.Play("regret4");
            phrase.Play();

        }
    }
}
