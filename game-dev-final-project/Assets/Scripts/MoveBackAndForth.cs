using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float distance = 5f;

    private Vector3 startPosition;
    // 1 for moving right, -1 for moving left
    private float direction = 1f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object horizontally
        float moveX = direction * speed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0f, 0f));

        // Check if the object reached the maximum distance
        if (Mathf.Abs(transform.position.x - startPosition.x) >= distance)
        {
            // Change the direction when reaching the distance
            direction *= -1f;
        }
    }
}
