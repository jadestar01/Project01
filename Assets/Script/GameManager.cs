using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int maxCoin;

    void Update()
    {
        if (WinProcessor())
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win");
        if (LoseProcessor())
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lose");
    }

    bool WinProcessor()
    {
        if (player.GetComponent<CharacterManager>().coinCount >= maxCoin)
        {
            return true;
        }

        return false;
    }

    bool LoseProcessor()
    {
        if (player.GetComponent<CharacterManager>().curHealth <= 0)
        {
            return true;
        }
        else if (player.transform.position.y < -10)
        {
            return true;
        }

        return false;
    }
}
