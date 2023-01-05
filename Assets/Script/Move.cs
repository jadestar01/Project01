using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int moveSpeed = 5;          //integer Á¤¼ö°ª
    Rigidbody2D rigid;
    Vector2 move;   //1

    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveFunc();
        rigid.velocity = new Vector2(move.x, rigid.velocity.y);  //2
    }

    public void ButtonUp()
    {
        move = new Vector2(0, rigid.velocity.y);        //3
    }

    public void MoveButton(int dir)
    {
        move = new Vector2(dir * moveSpeed, rigid.velocity.y);      //4
        if (dir == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (dir == -1)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    void MoveFunc()
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
