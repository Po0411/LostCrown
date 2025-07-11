using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    private Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = 0f; 

        animator.SetFloat("Speed", Mathf.Abs(movement.x));

        if (movement.x != 0)
        {
            Vector3 newScale = transform.localScale;
            newScale.x = Mathf.Sign(movement.x) * Mathf.Abs(newScale.x);
            transform.localScale = newScale;
        }
    }

    void FixedUpdate()
    {        
        rb.MovePosition(rb.position + new Vector2(movement.x, 0f) * moveSpeed * Time.fixedDeltaTime);
    }
}