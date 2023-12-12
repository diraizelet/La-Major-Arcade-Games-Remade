using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Maintain : MonoBehaviour
{
    public void Restart(){
        SceneManager.LoadScene(5);
    }

    public void Mainmenu(){
        SceneManager.LoadScene(0);
    }

}
