using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 
    public void PlayGame1 ()
    {
        SceneManager.LoadScene("Scene_1");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Scene_1.1");
    }

    public void QuitGame () {

        Debug.Log("QUIT!");

        Application.Quit();
   
            }    
}
