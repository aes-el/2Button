using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float movementHorizontal;
    public float maximumX = 7.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementHorizontal = Input.GetAxis("Horizontal");
        if ((movementHorizontal > 0 && transform.position.x < maximumX) ||
            (movementHorizontal < 0 && transform.position.x > -maximumX))
        {
            transform.position += Vector3.right * speed * movementHorizontal * Time.deltaTime;
        }
    }
}
