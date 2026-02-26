using System;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    
    // IN BOUNCYBALL 
    //using TMPro;
    
    
//    int score = 0; 
//    int lives = 5;
//    public TextMeshProUGUI scoreTxt;
//    public GameObject[] livesImage;
//    public GameObject gameOverPanel;
//    public GameObject youWinPanel;
//    int brickCount;

    void Start()
    {
        //brickCount = FindObjectsOfType<LevelGenerator>().transform.childCount;
    }
    //
    // private void Update()
    // {
    //     if (transform.position.y<minY)
    //     {
    //         if(lives <= 0)
    //         {
    //             GameOver();
    //         }
    //         else
    //         {
    //             transform.position = Vector3.zero;
    //             rb.velocity = Vector3.zero;
    //             lives--;
    //             livesImage[lives].SetActive(false);
    //         }
    //         
    //         
    //     }
    // }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     //if (collision.gameObject.CompareTag("Brick"))
    //     {
    //         score+=10;
    //         scoreTxt.text = score.ToString("0000");
    //         brickCount--;
    //         if(brickCount <= 0)
    //         {
    //             youWinPanel.SetActive(ture);
    //             Time.timeScale = 0;
    //         }
    //      }
    // }
    //
    // void GameOver()
    // {
    //     gameOverPane.SetActive(ture);
    //     Time.timeScale = 0;
    //     Destroy(gameObject);
    // }

    
    
    
    // IN LEVEL GENTERATOR
    
    // using UnityEngine.Scenemanagement;
    
    //void restart()
    //{
    //     Time.timeScale = 1;
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    
    
    
}


//drag score text mesh into ScoreTxt in the hierarchy
//drag all lifes into the Lives Image in the hierarchy 
//drag GameOverPanel to game over panel in the hierarchy
//drag level generator to on click and add function restart()
//drag YouWinPanel to you win panel in the hierarchy