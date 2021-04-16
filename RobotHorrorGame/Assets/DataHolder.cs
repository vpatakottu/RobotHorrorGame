using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public static class DataHolder 
{
    // Start is called before the first frame update

    //Sound is required for this activity - please turn on your speakers or use headphones.
    //You will first go through a training exercise to get used to the interface.  Make sure your sound is turned on. When you are ready, press Continue. 
    // private static int correctAgree=0;
    // private static int correctDisagree=0;
    // private static int incorrectAgree=0;
    // private static int incorrectDisagree=0; 
    // private static string id = ""; 

    private static List<string> allChoices = new List<string>();
    // private static List<int> allNumbersSelected = new List<int>();

    // private static bool inTrainingMode = true;


    // private static List<int> trainingCorrectSequence;
    // private static List<int> trainingRobotSequence;

    // private static List<int> actualCorrectSequence;
    // private static List<int> actualRobotSequence;

    private static List<string> formFieldNames;
    // private static string surveyVersion; 

    // private static bool wasPosted; 

    // private static List<int> indicesForAudio; 

    static DataHolder()
    {
    	//surveyVersion = "gesture";
    	formFieldNames = new List<string>();

		formFieldNames.Add("entry.2060067767");
		//formFieldNames.Add("entry.2060067767");
		formFieldNames.Add("entry.558579786");
		//formFieldNames.Add("entry.558579786");
		formFieldNames.Add("entry.1093542156");
		// formFieldNames.Add("entry.1093542156");
		// formFieldNames.Add("entry.677812993");
		// formFieldNames.Add("entry.675811886");
		// formFieldNames.Add("entry.1267273647");
    	// formFieldNames.Add("entry.366248278");

    }


    public static void UpdateChoices(string outcome)
    {   
    	allChoices.Add(outcome);
        Debug.Log("OUTCOME: " + outcome);
    
    }



    public static void PostToServer()
    {
    	WWWForm form = new WWWForm();
    	form.AddField(formFieldNames[0], string.Join(" ", allChoices.ToArray()));
        
        
        UnityWebRequest www = UnityWebRequest.Post("https://docs.google.com/forms/d/e/1FAIpQLSf6r6Z21yn5MbKAzmr5VxcaqRu_OWV_9QAAaw4ImQ6iQQIeDQ/formResponse", form);

    	www.SendWebRequest();

    	if (www.isNetworkError || www.isHttpError)
    	{
    		Debug.Log("www.error");

    	}
    	else
    	{
    		Debug.Log("Form upload complete!");
    		//wasPosted = true;
    	}
    }

    public static void PrintCurrentData()
    {
    	
    	Debug.Log("allChoices " + string.Join(",", allChoices.ToArray()));
    
    }

   

}
