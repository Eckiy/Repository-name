using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D tenRigidbody;

    public Animator animator; 

    Vector2 movement;

   // void Start()
  //  {
        
  //  }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Spid", movement.sqrMagnitude);
    }

    void FixedUpdate ()
    {
        tenRigidbody.MovePosition(tenRigidbody.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
