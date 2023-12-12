using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class trp : MonoBehaviour
{
   public void Restart(){
        SceneManager.LoadScene(4);
    }

    public void Mainmenu(){
        SceneManager.LoadScene(0);
    }
}
