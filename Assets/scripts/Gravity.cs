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

    // ��(�÷���) ���� ���� �� �߷� 0
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Background"))
        {
            rb.gravityScale = 1f;
        }
    }

    // �÷������� ����� �߷� 1
/*    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            rb.gravityScale = 1f;
        }
    }*/
}
