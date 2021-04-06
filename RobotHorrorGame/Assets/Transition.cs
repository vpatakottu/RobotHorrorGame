using UnityEngine;
using UnityEngine.SceneManagement;
public class Transition : MonoBehaviour
{
    public Animator animator;
    public int levelToLoad;
    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0)) {
        //     FadeToLevel(1);
        // }
    }
    public void FadeToLevel(int levelIndex) {
        levelToLoad = levelIndex;
        animator.SetTrigger("Fade_out");
    }
    public void OnFadeComplete() {
        SceneManager.LoadScene(levelToLoad);
    }
}
