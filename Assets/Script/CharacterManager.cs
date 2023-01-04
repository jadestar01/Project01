using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterManager : MonoBehaviour
{
    [Header("Coin Component")]
    public int coinCount = 0;      //코인 개수
    [Header("Health Component")]
    public int maxHealth = 3;      //최대체력
    public int curHealth = 3;      //현재체력
    public int initHealth = 3;     //시작체력

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            coinCount++;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Health")
        {
            if (curHealth + 1 > maxHealth)
            {
                //만약 체력을 먹었는데, 최대체력보다 많아지면, 안되기 때문에 예외처리를 했다.
            }
            else
            {
                curHealth++;
                Destroy(collision.gameObject);
            }
        }
        else if (collision.tag == "Spike")
        {
            curHealth--;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "CannonBall")
        {
            curHealth--;
            Destroy(collision.gameObject);
        }
    }
}
