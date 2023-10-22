using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnTouch : MonoBehaviour
{
    [SerializeField] string levelToRestart = "LevelOnePlayGround";

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            Debug.Log("Player touched the water block.");
            SceneManager.LoadScene(levelToRestart);
        }
    }
}
