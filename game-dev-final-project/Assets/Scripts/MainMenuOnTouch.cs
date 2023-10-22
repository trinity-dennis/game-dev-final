using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuOnTouch : MonoBehaviour
{
    [SerializeField] string SceneToGo = "MainMenu";

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            Debug.Log("Player touched barriar.");
            SceneManager.LoadScene(SceneToGo);
        }
    }
}
