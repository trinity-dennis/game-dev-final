using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovementController : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] float jumpForce = 5.0f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake(){
    }

    void Start(){
        rb = playerMovement.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()){
            rb.velocity = new Vector3(rb.velocity.x, jumpForce);
        }
    }

    void FixedUpdate()
    {
        Vector3 vel = Vector3.zero;

        if(Input.GetKey(KeyCode.A)){
            vel.x = -1;
        }if(Input.GetKey(KeyCode.D)){
            vel.x = 1;
        }

        playerMovement.MoveRB(vel);
    }

    bool IsGrounded(){
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
