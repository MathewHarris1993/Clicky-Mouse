using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyBotton : MonoBehaviour
{

    // refernce to gamemanger
    private GameManager gameManager;

    //set button variable
    private Button button;

    //difficulty variable
    public int difficulty;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        

    }

   //create difficulty method
   void SetDifficulty()
    {
        gameManager.StartGame(difficulty);


    }
}
