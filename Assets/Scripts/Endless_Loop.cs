using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Endless_Loop : MonoBehaviour
{
    
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player") {
            FindObjectOfType<Endless_Score>().high_score = int.Parse(FindObjectOfType<Endless_Score>().score.text);
            //DontDestroyOnLoad(FindObjectOfType<Endless_Score>().offset);
            //DontDestroyOnLoad(FindObjectOfType<Endless_Score>());

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
      
    }
}
