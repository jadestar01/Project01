using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    public float cannonBallSpeed = 5.0f;
    public float killTime = 5.0f;

    private void Start()
    {
        StartCoroutine(KillYourSelf());
    }

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * cannonBallSpeed);
    }

    IEnumerator KillYourSelf()
    {
        yield return new WaitForSeconds(killTime);
        Destroy(gameObject);
    }
}
