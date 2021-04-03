using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public void LoadScene(string game)
    { 
         SceneManager.LoadScene(game);
    }

    public void QuitGame ()
    {
        Debug.Log ("quit!");
        Application.Quit();
    }

    public void Data()
    {
        SharedData.click=SharedData.click + 1;
        Debug.Log(SharedData.click);
    }
}
