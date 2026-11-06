using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float gravity;
    public Transform camera;
    public Rigidbody rb;
    private Vector2 input;
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        input.Normalize();


        if (input != Vector2.zero)
        {
            Vector2 dir = new Vector2(input.x, input.y).normalized;
            float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }
        
        camera.position = transform.position;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(input.x, gravity , input.y) * speed;
        //rb.AddForce(new Vector3(input.x, gravity, input.y) * speed, ForceMode.Force);
    }
}
