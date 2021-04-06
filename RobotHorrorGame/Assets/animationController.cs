using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{

    public Animator an;
    
    // Start is called before the first frame update
    void Start()
    {
        an = GetComponent<Animator>();   

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1")) {
            an.Play("picknum1");
        }
        if (Input.GetKeyDown("2"))  {
            an.Play("picknum2");
        }
        if (Input.GetKeyDown("3")) {
            an.Play("picknum3");
        }
        
    }
}
