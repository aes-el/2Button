using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    public float minY = -5.5f;
    private Rigidbody2D rb;
    public float maxVelocity = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minY)
        {
            transform.position = Vector3.zero;
            rb.linearVelocity = Vector2.zero;
        }

        if (rb.linearVelocity.magnitude > maxVelocity)
        {
            rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, maxVelocity);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
 {
     if (collision.gameObject.CompareTag("Brick"))
     {
         Destroy(collision.gameObject);
     }
 }
}
