using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] protected float speed = 5;
    [SerializeField] AnimationStateChanger animationStateChanger;
    [SerializeField] Transform body;
    
    protected Rigidbody2D rb;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveRB(Vector3 vel){
        rb.velocity = new Vector3(vel.x * speed, rb.velocity.y);

        if(vel.magnitude > 0){
            animationStateChanger.ChangeAnimationState("Run", speed/5);

            if(vel.x > 0){
                body.localScale = new Vector3(1, 1, 1);
            }else if(vel.x < 0){
                body.localScale = new Vector3(-1, 1, 1);
            }
        }else if (rb.velocity.y > 0){
            animationStateChanger.ChangeAnimationState("Jump");
        }else if (rb.velocity.y < 0){
            animationStateChanger.ChangeAnimationState("Fall");
        }else{
            animationStateChanger.ChangeAnimationState("Idle");
        }
    }
    
}
