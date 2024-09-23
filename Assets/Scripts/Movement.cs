using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5f;
    public Animator animator;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 movedirection;
    private Rigidbody rb;

    void Start() 
    {

        rb = GetComponent<Rigidbody>();
        
    }

    void Update() 
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        movedirection = new Vector3(horizontalInput,0,verticalInput);
        
        transform.Translate(movedirection*speed*Time.deltaTime);

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run",true);
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        else
        {
            animator.SetBool("Run",false);
        }

        if(rb.velocity.y<=0.1)
        {
            animator.SetFloat("Blend",0);
        }
    }

    void Jump()
    {
        // Add a vertical force for jumping
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);

        animator.SetFloat("Blend",rb.velocity.y);
    }
}


