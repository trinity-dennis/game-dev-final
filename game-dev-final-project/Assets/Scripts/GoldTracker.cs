using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldTracker : MonoBehaviour
{
    private Text goldText;
    private int collected = 0;
    public int goldTarget = 5; // Set the target value

    void Start()
    {
        goldText = GetComponentInChildren<Text>();

        // Check if a Text component was found
        if (goldText == null)
        {
            Debug.LogError("UI Text component not found on ScoreTracker GameObject.");
        }
        else
        {
            UpdateGoldText();
        }
    }

    public void AddScore(int gold)
    {
        collected += gold;
        UpdateGoldText();
    }

    public bool HasReachedTarget()
    {
        return collected >= goldTarget;
    }

    private void UpdateGoldText()
    {
        if (goldText != null)
        {
            goldText.text = "Gold Collected: " + collected.ToString() + "/" + goldTarget.ToString();
        }
    }
}