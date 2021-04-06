using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    //public int startingLives;
    private int lifeCounter;
    public UnityEngine.UI.Text lifetext;
    //public CharacterController player;

    // Start is called before the first frame update
    void Start()
    {
        //text = GetComponent<Text>();
        lifeCounter = PlayerPrefs.GetInt("PlayerCurrentLives");
        //player = FindObjectOfType<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //text = GetComponent<Text>();
        //Debug.Log("TEXT: " + lifetext.text);
        if (lifetext == null) {
            Debug.Log("NULL LIFECOUNTER");
        } else {
            lifetext.text = "Lives Remaining: " + lifeCounter;

        }
    }

    public void RemoveLife() {
        lifeCounter--;
        if (lifeCounter == 0) {
            GameOver();
        }
        PlayerPrefs.SetInt("PlayerCurrentLives", lifeCounter);
    }

    public void GameOver() {
        SceneManager.LoadScene(11);
    }
}
