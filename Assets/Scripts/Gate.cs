using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{
    void Start()
    {
        //GameManager manager = GameObject.Find("MainMenu_UI").GetComponent<GameManager>;
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.GetComponent<PlayerControl>())
        {
            SceneManager.LoadScene("WinScreen");   
        }
        
    }
}
