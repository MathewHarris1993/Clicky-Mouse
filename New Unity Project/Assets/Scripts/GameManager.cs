using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    //attach gameObject prefabs
    public List<GameObject> targets;


    //set spawn rate
    private float spawnRate = 1;


    //GUI variables
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    //game over variable
    public bool isGameActive;

    //restart variable
    public Button restart;

    //title screen variable
    public GameObject titleScreen;


    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // code to start game in public method. 
    public void StartGame(int difficulty)
    {
        //set game over variable
        isGameActive = true;


        //spawn the targets
        StartCoroutine(SpawnTarget());

        //set default score
        score = 0;

        //begin to track score
        UpdateScore(0);

        //remove title screen
        titleScreen.gameObject.SetActive(false);

        //set diff by changing spawn rate
        spawnRate = spawnRate / difficulty;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //create ability to spawn targets
    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {

            //time between spawns
            yield return new WaitForSeconds(spawnRate);

            //create index to allow random object spawm
            int index = Random.Range(0, targets.Count);

            //selects random target
            Instantiate(targets[index]);
        }

    }

    //track score
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    //create game over
    public void GameOver()
    {
        //spawn game over text
        gameOverText.gameObject.SetActive(true);

        //set game state to game over
        isGameActive = false;

        //show restart button
        restart.gameObject.SetActive(true);


    }

    //allow game to restart
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
