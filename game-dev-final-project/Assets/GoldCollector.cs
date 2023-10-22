using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCollector : MonoBehaviour
{
    [SerializeField] int goldAdded = 0;
    private static bool hasCollided = false;
    private GoldTracker goldTracker;
    void Start()
    {
        // Find the ScoreTracker script in the scene
        goldTracker = FindObjectOfType<GoldTracker>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {   
            // add to score
            goldTracker.AddScore(goldAdded);
            
            // Destroy the star
            Destroy(gameObject);
        }
    }
}
