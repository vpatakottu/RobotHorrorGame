using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
using UnityEngine.EventSystems;

public class UserChoices : MonoBehaviour
{
    // Start is called before the first frame update
    //private String userChoices[];
    private string userChoice;
    void Start()
    {
        //userChoices =  new String[5];
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey("left")) {
           Debug.Log("LEFT");
       } else if (Input.GetKey("right")) {
           Debug.Log("Right");
       }

    }

    public void RecordUserChoice(string choice) {
        userChoice = choice;
    }
}
