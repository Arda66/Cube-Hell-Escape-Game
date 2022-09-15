using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float addforce = 2000f;
    public float sidewaysforce = 500f;
    public GameObject pause;


  
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, addforce * Time.deltaTime);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -addforce * Time.deltaTime);

        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey(KeyCode.Escape))
        {
            pause.SetActive(true);
            FindObjectOfType<PlayerMovement>().enabled = false;
            //GameObject.Find("PauseMenu").SetActive(true);

        }

        if(rb.position.y < -1)
        {
            FindObjectOfType<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
        
        

    }
}
