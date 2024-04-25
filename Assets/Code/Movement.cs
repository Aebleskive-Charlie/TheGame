using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 15;
    public float jumpForce = 15f;
    public float gravity = -25f;
    public float rotationSpeed = 180;
    public float sprintspeed = 5f;

    CharacterController controller; 
    Vector3 moveVelocity;

   
    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed + sprintspeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed - sprintspeed;
        }


            if (controller.isGrounded)
        {
                moveVelocity = new Vector3(horizontal, 0, vertical) * speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpForce;
            }
        }
        moveVelocity.y += gravity * Time.deltaTime;
        controller.Move(transform.TransformDirection(moveVelocity) * Time.deltaTime);
    }
}
