using UnityEngine;

public class BallOfBounce : MonoBehaviour
{
    Rigidbody2D rb;
    public float maxSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OB"))
        {
            transform.position = Vector3.zero;
            rb.linearVelocity = Vector3.zero;
        }
        else if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
        }
    }
    void FixedUpdate()
    {
        if (rb.linearVelocity.magnitude > maxSpeed)
        {
            rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, maxSpeed);
        }
    }
}
