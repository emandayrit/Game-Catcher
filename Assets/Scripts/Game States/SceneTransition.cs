using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] string gameSceneName = "GameScene";
    [SerializeField] string menuSceneName = "MainMenu";

    public void PlayGame()
    {
        // Goes to the next scene index which is the game scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(gameSceneName);
    }    
    
    public void BackToMenu()
    {
        // Goes back to scene index 0 which is the menu
        //SceneManager.LoadScene(0);
        SceneManager.LoadScene(menuSceneName);
    }

    public void ExitGame()
    {
        Debug.Log("Game Closed");
        
        // Game will close in the build
        Application.Quit();
    }
}
