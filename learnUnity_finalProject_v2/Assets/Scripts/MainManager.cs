using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainManager : MonoBehaviour
{

    //public static MainManager Instance;

    public GameObject gameOverText;


    private float playerZDestroy = -74;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    private float score;
    private float scoreIncreasePerSecond;
    private float pointMultiplyer = 10;
    private const string STOREDHIGHSCORENAME = "High score";

    public bool isGameActive;
    public bool isGameOver;

    private void Awake()
    {
        //if (Instance != null)
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        //Instance = this;
        //DontDestroyOnLoad(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {


        isGameActive = true;
        isGameOver = false;
        gameOverText.SetActive(false);

        score = 0;
        scoreIncreasePerSecond = 1;

        float storedHighScore = PlayerPrefs.GetFloat(STOREDHIGHSCORENAME, 0);
        highScoreText.text = "HIGH SCORE: " + (int)storedHighScore;


    }

    // Update is called once per frame
    void Update()
    {
        //ABSTRACTION
        IncreaseScorePerSecond();

        GameObject player = GameObject.Find("Player");

        if (player.transform.position.z < playerZDestroy)
        {
            GameOver();
        }

        if (isGameOver == true)
        {
            gameOverText.SetActive(true);

            }
            else
            {
                gameOverText.SetActive(false);
            }
        }



        void IncreaseScorePerSecond()
        {
            scoreText.text = "SCORE: " + (int)score;
            if (isGameActive == true)
            {
                score += scoreIncreasePerSecond * Time.deltaTime * pointMultiplyer;
            }


        }

    void GameOver()
    {
        isGameActive = false;
        isGameOver = true;
        SetHighScoreText();

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //}
    }

    void SetHighScoreText()
    {
        //ENCAPSULATION
        // Get the high score, or return default

        float storedScore = PlayerPrefs.GetFloat(STOREDHIGHSCORENAME, 0);

        if (score > storedScore)
        {
            PlayerPrefs.SetFloat(STOREDHIGHSCORENAME, score);
        }

        highScoreText.text = "HIGH SCORE:" + (int)score;
    }

}
