using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class door_script : MonoBehaviour
{
   
    private Animator anim;
    bool doorOpen;

    //public bool closed;
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<Animator>().SetBool("open", true); //open door
        //OR
        anim = gameObject.GetComponent<Animator>();
        doorOpen = false;
        anim.SetBool("open", false);
      
    }

    
  
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Pressed();
            Debug.Log("going to Pressed method now");
        }

    }

    void Pressed()
    {
        if (doorOpen == false)
        {
            anim.SetBool("open", true); //set bool so if door is at closed state it will transition
            doorOpen = true;
            Debug.Log("door goes from closed to open");
        }

        if (doorOpen == true)
        {
            anim.SetBool("open", false); //set bool so if door is at open state it will transition
            doorOpen = false;
            Debug.Log("door goes from open to closed");
        }
    }

       
 


}
