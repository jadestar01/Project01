using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterManager : MonoBehaviour
{
    [Header("Coin Component")]
    public int coinCount = 0;      //���� ����
    [Header("Health Component")]
    public int maxHealth = 3;      //�ִ�ü��
    public int curHealth = 3;      //����ü��
    public int initHealth = 3;     //����ü��

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
                //���� ü���� �Ծ��µ�, �ִ�ü�º��� ��������, �ȵǱ� ������ ����ó���� �ߴ�.
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
