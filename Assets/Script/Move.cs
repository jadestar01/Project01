using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int moveSpeed = 5;          //integer Á¤¼ö°ª
    Rigidbody2D rigid;

    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rigid.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rigid.velocity.y);
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
