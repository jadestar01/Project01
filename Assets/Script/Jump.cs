using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Net;
using System.Security.Principal;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int jumpPower = 10;
    Rigidbody2D rigid;
    bool isGrounded;
    [Header("점프 중력")] public float jumpingGravity = 3;
    [Header("낙하 중력")] public float fallingGravity = 8;

    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();

        StartCoroutine(CountDown());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)            //땅에 닿아있을 때, 점프를 눌렀다면, 
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }

        GroundCheck();
        GractiyContorller();
    }

    void GroundCheck()
    {
        Debug.DrawRay(new Vector2(transform.position.x - 0.4f, transform.position.y), Vector2.down * 0.6f, Color.red);
        Debug.DrawRay(new Vector2(transform.position.x + 0.4f, transform.position.y), Vector2.down * 0.6f, Color.red);

        bool ray1 = false;
        bool ray2 = false;

        if (Physics2D.Raycast(new Vector2(transform.position.x - 0.4f, transform.position.y),
                                Vector2.down,
                                0.6f,
                                LayerMask.GetMask("Wall", "Cannon"))) ray1 = true;
        if (Physics2D.Raycast(new Vector2(transform.position.x + 0.4f, transform.position.y),
                                Vector2.down,
                                0.6f,
                                LayerMask.GetMask("Wall", "Cannon"))) ray2 = true;

        if (!ray1 && !ray2)
        { isGrounded = false; }
        else
        { isGrounded = true; }
    }

    void GractiyContorller()
    {
        if (!isGrounded)
        {
            if (rigid.velocity.y > 0)
                rigid.gravityScale = jumpingGravity;
            else if (rigid.velocity.y <= 0)
                rigid.gravityScale = fallingGravity;
        }
        else
            rigid.gravityScale = 1;
    }

    IEnumerator CountDown()
    {
        int a = 0;
        while (true)
        {
            Debug.Log(a + "초 경과");
            yield return new WaitForSeconds(1.0f);
            a++;
        }
    }
}
