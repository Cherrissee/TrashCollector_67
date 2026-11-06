using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ObserverManager : MonoBehaviour
{
    public GameObject gate_texture;
    public GameObject orb;
    public TMP_Text score;
    public int orb_count;

    void Start()
    {
        for (int i = 0; i < orb_count; i++)
        {
            Instantiate(orb);
        }
    }
    
    public void Update()
    {
        score.text = "Trash Left: "+ orb_count;
        if (orb_count <= 0)
        {
            gate_texture.SetActive(true);
        }
    }

}
