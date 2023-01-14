using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float runspeed = 10.0f;
    

    public float rotx = 270;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    public Animator Anim;
    void Start()
    {
        controller = GetComponent<CharacterController>();

        // let the gameObject fall down
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection.Normalize();


            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveDirection = moveDirection * runspeed;
                    }
            else {
                moveDirection = moveDirection * speed;
            }
            
            
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
        Vector3 Rot = new Vector3(0, Input.GetAxis("Mouse X"), 0) * rotx;

        transform.Rotate(Rot * Time.deltaTime);
        Vector3 temp = moveDirection;

        temp.y = 0;

        Anim.SetFloat("speed", temp.magnitude);

    }
}
