using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public void fruitNinja()
    {
        SceneManager.LoadScene(4);
    }

    public void Mines()
    {
        SceneManager.LoadScene(1);
    }

    public void towerdef1()
    {
        SceneManager.LoadScene(2);
    }

    public void gameoflife()
    {
        SceneManager.LoadScene(5);
    }

    public void snake()
    {
        SceneManager.LoadScene(6);
    }

    public void exit()
    {
        Application.Quit();
    }
}
