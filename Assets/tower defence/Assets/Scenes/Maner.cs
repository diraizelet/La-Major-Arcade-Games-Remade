using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maner : MonoBehaviour
{
    public void Restart(){
        SceneManager.LoadScene(2);
    }

    public void Mainmenu(){
        SceneManager.LoadScene(0);
    }
}
