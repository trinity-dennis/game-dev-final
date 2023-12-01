using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOnTouch : MonoBehaviour
{
    [SerializeField] string SceneToGo = "MainMenu";
    [SerializeField] GoldTracker goldTracker; // Reference to GoldTracker script

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Check if the gold tracker has reached 5/5
            if (goldTracker != null && goldTracker.HasReachedTarget())
            {
                Debug.Log("Player collided with barrier. Gold target reached!");
                SceneManager.LoadScene(SceneToGo);
            }
            else
            {
                Debug.Log("Player collided with barrier, but gold target not reached yet.");
                // Optionally provide feedback to the player or take other actions.
            }
        }
    }
}