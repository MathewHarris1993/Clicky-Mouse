using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    //attach gameObject prefabs
    public List<GameObject> targets;


    //set spawn rate
    private float spawnRate = 1;


    //GUI variables
    private int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //spawn the targets
        StartCoroutine(SpawnTarget());

        //set default score
        score = 0;

        //begin to track score
        UpdateScore(0);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //create ability to spawn targets
    IEnumerator SpawnTarget()
    {
        while(true)
        {

            //time between spawns
            yield return new WaitForSeconds(spawnRate);

            //create index to allow random object spawm
            int index = Random.Range(0, targets.Count);

            //selects random target
            Instantiate(targets[index]);

            //test score counter
            UpdateScore(5);


        }

    }

    //track score
    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
