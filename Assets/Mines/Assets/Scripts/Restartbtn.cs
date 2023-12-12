using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;
public class Restartbtn : MonoBehaviour
{
  
    public void Restart(){
        SceneManager.LoadScene(1);
    }
    
    public void Mainmenu(){
        SceneManager.LoadScene(0);
    }
}
