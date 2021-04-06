using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 15f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float ground_distance = 0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool onGround;

    // Update is called once per frame
    void Update()
    {
        onGround = Physics.CheckSphere(groundCheck.position, ground_distance, groundMask);

        if (onGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 direction = transform.right * horiz + transform.forward * vert;

        controller.Move(direction * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
