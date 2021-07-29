using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    public float gravity = 20f;
    public float jump = 12f;

    CharacterController  Controller;

    Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.isGrounded)
        {
            moveDirection = new Vector3 (Input.GetAxis("Horizontal"), .0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
            moveDirection = transform.TransformDirection(moveDirection);
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jump;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        Controller.Move(moveDirection * Time.deltaTime);
    }
}
