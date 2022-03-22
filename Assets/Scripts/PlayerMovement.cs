
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed=5;
    public Rigidbody rb;

    void Start() {
        Time.timeScale = 1;
    }
    private void FixedUpdate() 
    {

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove);
    }

    void Update()
    {
        
    }
}
