using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public bool isRight = true;
    public float fireTime = 3.0f;
    public GameObject cannonball;
    public GameObject shotPosition;

    private void Start()
    {
        if (isRight == true)
        {
        }
        else if (isRight == false)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        StartCoroutine(ShotBall());
    }

    IEnumerator ShotBall()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireTime);
            MakeCannonBall();
        }
    }

    public void MakeCannonBall()
    {
        if (isRight == true)
        {
            Instantiate(cannonball, shotPosition.transform.position, Quaternion.identity);
        }
        else if (isRight == false)
        {
            Instantiate(cannonball, shotPosition.transform.position, Quaternion.Euler(0, 180, 0));
        }
    }
}
