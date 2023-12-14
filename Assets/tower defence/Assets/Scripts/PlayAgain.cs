using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    //Play Again
    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //level 2
    public void nextScene()
    {
        SceneManager.LoadScene("Level2");
    }
    //level 1
    public void prevScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
