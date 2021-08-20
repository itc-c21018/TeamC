using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public StageGenerator generator;
    public Text scoreTextER;
    public int scoreE1;
    public int scoreE2;
    public int scoreE3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreTextER.text = generator.score + "m";

        /*PlayerPrefs.SetInt("scoreE3rd", scoreE3);
        PlayerPrefs.SetInt("scoreE2nd", scoreE2);
        PlayerPrefs.SetInt("scoreE1st", scoreE1);*/

        


        if (scoreE3 < generator.score && scoreE2 > generator.score) ;
        {
            scoreE3 = generator.score;
            

            if (scoreE2 < generator.score && scoreE1 > generator.score) ;
            {
                scoreE2 = generator.score;
                

                if (scoreE1 < generator.score) ;
                {
                    scoreE1 = generator.score;
                    PlayerPrefs.SetInt("scoreE1st", scoreE1);

                }
                PlayerPrefs.SetInt("scoreE2nd", scoreE2);
            }

            PlayerPrefs.SetInt("scoreE", scoreE3);
        }
    }
    
    void GameEndE()
    {

    }
}
