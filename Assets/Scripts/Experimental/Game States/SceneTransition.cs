using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void PlayGame()
    {
        // Goes to the next scene index which is the game scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    
    
    public void BackToMenu()
    {
        // Goes back to scene index 0 which is the menu
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Debug.Log("Game Closed");
        
        // Game will close in the build
        Application.Quit();
    }
}
