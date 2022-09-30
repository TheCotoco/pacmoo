using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    MovementController movementcontroller;
    public SpriteRenderer sprite;
    public Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        movementcontroller = GetComponent<MovementController>();
        animator = GetComponentInChildren<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("moving", true);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementcontroller.setDirection("left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementcontroller.setDirection("right");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementcontroller.setDirection("up");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementcontroller.setDirection("down");
        }

        bool flipX = false;
        bool flipY = false;

        if(movementcontroller.lastMovingDirection == "left")
        {
            animator.SetInteger("direction", 0);
        }

        if (movementcontroller.lastMovingDirection == "right")
        {
            animator.SetInteger("direction", 0);
            flipX = true;
        }

        if (movementcontroller.lastMovingDirection == "up")
        {
            animator.SetInteger("direction", 1);
        }

        if (movementcontroller.lastMovingDirection == "down")
        {
            animator.SetInteger("direction", 1);
            flipY = true;
        }

        sprite.flipX = flipX;
        sprite.flipY = flipY;
    }
}
