using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public CharacterController controller;
    public float speed = 20f;

    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;

    // Update is called once per frame
    void Update()
    {
        activeStrafeSpeed  = Input.GetAxisRaw("Horizontal") * speed;
        activeForwardSpeed = Input.GetAxisRaw("Vertical") * speed;
        activeHoverSpeed = Input.GetAxisRaw("Hover") * speed;

        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;

        transform.position += (transform.right * activeStrafeSpeed * Time.deltaTime) + (transform.up * activeHoverSpeed * Time.deltaTime);
    }
}

