using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public Animator animator;
    private float horizontalInput;
    private Vector3 movedirection;

    void Update() 
    {
        horizontalInput = Input.GetAxis("Horizontal");
        movedirection = new Vector3(0,0,horizontalInput);
        transform.Translate(movedirection*speed*Time.deltaTime);

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Run",true);
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("RunBack",true);
        }
        else
        {
            animator.SetBool("Run",false);
            animator.SetBool("RunBack",false);
        }
    }
}
