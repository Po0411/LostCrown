using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactor : MonoBehaviour
{
    //BoxCollider2D collider;
    Animator anim;
    Rigidbody2D rb;
    SpriteRenderer sprite;

    public float speed = 5f;
    public float jumpForce = 7f;

    void Start()
    {
        //collider = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 direction = Vector3.zero;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (h < 0)
        {
            sprite.flipX = true;
            anim.SetBool("run", true);
            direction = Vector3.left;
        }
        else if (h > 0)
        {
            sprite.flipX = false;
            anim.SetBool("run", true);
            direction = Vector3.right;
        }
        else
        {
            anim.SetBool("run", false);
        }

        transform.position += direction * speed * Time.deltaTime;

        // มกวม 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            StartCoroutine(test());
        }
        if (v > 0)
        {
            anim.SetBool("run", true);
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if (v < 0) {
            anim.SetBool("run", true);
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    IEnumerator test()
    {
        yield return new WaitForSeconds(1f);
        anim.SetTrigger("fall");
    }
}
