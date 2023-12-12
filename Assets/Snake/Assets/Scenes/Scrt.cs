using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scrt : MonoBehaviour
{
    public void Restart(){
        SceneManager.LoadScene(6);
    }

    public void Mainmenu(){
        SceneManager.LoadScene(0);
    }
}
