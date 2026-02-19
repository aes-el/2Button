using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float movementHorizontal;
    public float maximumX = 7.5f;
    public InputActionReference spaceBar;
    private int timer;
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

        if (spaceBar.action.WasPressedThisFrame())
        {
            speed = speed * 1.5f;
        }

        timer += 1;
        
        if (speed > 15 && timer % 10 == 0)
        {
            for (int i = 0; i < 5; i++)
            {
                speed = speed - 0.05f;
            }
            
        }
    }
}