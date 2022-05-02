using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{
    private void Update()
    {
        if (Ship.PrecentageHealth <= 0)
        {
            gameOver();
        }
    }
    void gameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
