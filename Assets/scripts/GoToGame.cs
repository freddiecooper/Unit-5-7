using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GoToGame : MonoBehaviour
{
    public GameObject menuFirst, optionsFirst, instructionsFirst, quitFirst, difficultyFirst, gameFirst;

    public void LoadScene(string game)
    { 
         SceneManager.LoadScene(game);
    }

    public void QuitGame ()
    {
        Debug.Log ("quit!");
        Application.Quit();
    }
    
    public void OptionsNav()
   {
      EventSystem.current.SetSelectedGameObject(null);
      EventSystem.current.SetSelectedGameObject(optionsFirst);
   }
   public void MainMenuNav()
   {
      EventSystem.current.SetSelectedGameObject(null);
      EventSystem.current.SetSelectedGameObject(menuFirst);
   }
   public void InstructionsNav()
   {
      EventSystem.current.SetSelectedGameObject(null);
      EventSystem.current.SetSelectedGameObject(instructionsFirst);
   }
   public void QuitNav()
   {
      EventSystem.current.SetSelectedGameObject(null);
      EventSystem.current.SetSelectedGameObject(quitFirst);
   }
   public void DifficultyNav()
   {
      EventSystem.current.SetSelectedGameObject(null);
      EventSystem.current.SetSelectedGameObject(difficultyFirst);
   }
   public void GameNav()
   {
      EventSystem.current.SetSelectedGameObject(null);
      EventSystem.current.SetSelectedGameObject(gameFirst);
   }

    public void Data()
    {
        SharedData.click=SharedData.click + 1;
        Debug.Log(SharedData.click);
    }
}
