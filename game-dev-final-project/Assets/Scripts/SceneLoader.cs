using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    // Update is called once per frame
    public void OnStartButtonClicked()
    {
        LoadNextScene();  
    }

    public void LoadNextScene(){
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene(){
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene("LevelOnePlayGround");
    }
}
