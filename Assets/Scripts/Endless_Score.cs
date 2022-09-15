using UnityEngine;
using UnityEngine.UI;
public class Endless_Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    public int high_score = 0;
    //public int offset;
    void Update()
    {
        score.text = (player.position.z + high_score).ToString("0");
    }
}