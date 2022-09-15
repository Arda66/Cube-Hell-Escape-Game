using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void Endgame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Game Over!");
            gameHasEnded = true;
            Invoke("Restart",2f);
        }
    }
       void Restart()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        } 

    
   
}
