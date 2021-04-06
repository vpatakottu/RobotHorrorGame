using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPress : MonoBehaviour
{
    public KeyCode key;
    private Button button;

    void Awake() {
        button = GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key)) {
            button.onClick.Invoke();
        }
    }
}
