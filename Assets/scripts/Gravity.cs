using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // ±æ(ÇÃ·§Æû) À§¿¡ ÀÖÀ» ¶§ Áß·Â 0
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Background"))
        {
            rb.gravityScale = 1f;
        }
    }

    // ÇÃ·§Æû¿¡¼­ ¹þ¾î³ª¸é Áß·Â 1
/*    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            rb.gravityScale = 1f;
        }
    }*/
}
