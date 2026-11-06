using UnityEngine;

public class PelletBehavior : MonoBehaviour
{
    public Vector2 min_bound;
    public Vector2 max_bound;
    private Rigidbody rb;
    private ObserverManager obmag;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        obmag = GameObject.Find("ObserverManager").GetComponent<ObserverManager>();
    }

    void Start()
    {
        SpawnBehavior();
        
    }

    void SpawnBehavior()
    {
        int pos_x = Random.Range((int)min_bound.x, (int)max_bound.x);
        int pos_y = Random.Range((int)min_bound.y, (int)max_bound.y);
        Vector3 pos = new Vector3(pos_x, 0.4f, pos_y);
        rb.position = pos;
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerControl>())
        {
            Destroy(gameObject);
            obmag.orb_count--;
            
        }
        else 
        {
            if (other.gameObject != gameObject)
            {
                Debug.Log(other.name);
                SpawnBehavior();
                
            }
        }
    }
}
