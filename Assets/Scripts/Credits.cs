using UnityEngine.SceneManagement;
using UnityEngine;



public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Continue()
    {
        GameObject.Find("PauseMenu").SetActive(false);
        FindObjectOfType<PlayerMovement>().enabled = true;
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene("Credits");
    }
    
}
