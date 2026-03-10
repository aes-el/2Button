using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BouncyBall : MonoBehaviour
{
    public float minY = -5.5f;
    private Rigidbody2D rb;
    public float maxVelocity = 15f;
    int score = 0; 
    int lives = 5;
    public TextMeshProUGUI scoreTxt;
    public GameObject[] livesImage;
    public GameObject gameOverPanel;
    public GameObject youWinPanel;
    public List <GameObject> brickCount = new List <GameObject>();
    [SerializeField] private LevelGenerator levelGenerator;
    public GameObject myLevelGenerator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //levelGenerator = GameObject.Find("LevelGenerator").GetComponent<LevelGenerator>();
        rb = GetComponent<Rigidbody2D>();
        for (int i = 0; i <levelGenerator.size.x * levelGenerator.size.y; i++)
        {
            brickCount.Add(GameObject.FindWithTag("Brick"));
        }
        Debug.Log(brickCount.Count);
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
        if (transform.position.y<minY)
        {
            if(lives <= 0)
            {
                GameOver();
            }
            else
            {
                transform.position = Vector3.zero;
                rb.linearVelocity = Vector3.zero;
                lives--;
                livesImage[lives].SetActive(false);
            }
            
            
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            score+=10;
            scoreTxt.text = score.ToString("0000");
            brickCount.Remove(collision.gameObject);
            if(brickCount.Count <= 0)
            {
                youWinPanel.SetActive(true);
                Time.timeScale = 0;
            }
            Debug.Log(brickCount.Count);
         }
    }
    void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
        Destroy(gameObject);
    }
}
