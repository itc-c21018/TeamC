using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public TapiokaController tapioka;
    //public Text scoreText;
    public LifePanel lifePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //int score = CalcScore();
        //scoreText.text = "Score : " + score + "m";

        lifePanel.UpdateLife(tapioka.Life());

        //
        if(tapioka.Life() <= 0)
        {
            //
            enabled = false;

            /*if (PlayerPrefs.GetInt("HighScore") < score)
            {
                PlayerPrefs.SetInt("HighScore", score);
            }*/

            //
            //Invoke("ReturnToTitle", 2.0f);
        }
    }

    /*int CalcScore()
    {
        return (int)tapioka.transform.position.z;
    }

    void ReturnToTitle()
    {
        SceneManager.LoadScene("Title");
    }*/
}
