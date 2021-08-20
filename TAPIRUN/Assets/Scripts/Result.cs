using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    //public StageGenerator generator;
    public TapiokaController tapioka;
    public RectTransform rdRT;
    float positionY = -1200;
    //public Text scoreText;
    public LifePanel lifePanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lifePanel.UpdateLife(tapioka.Life());
        rdRT.localPosition = new Vector3(0, positionY, 0);
        //
        if (tapioka.Life() <= 0)
        {
            //
            Invoke("ResultDisplay", 1.5f);

            //enabled = false;

            
        }
    }

    void ResultDisplay()
    {
        positionY = 0;

        /*if (PlayerPrefs.GetInt("scoreE1st") < generator.score) ;
        {
            //PlayerPrefs.SetInt("scoreE3rd", PlayerPrefs.GetInt("scoreE2nd"));
            //PlayerPrefs.SetInt("scoreE2nd", PlayerPrefs.GetInt("scoreE1st"));
            PlayerPrefs.SetInt("scoreE1st", generator.score);

        }
        if (PlayerPrefs.GetInt("scoreE2nd") < generator.score && PlayerPrefs.GetInt("scoreE1st") > generator.score) ;
        {
            //PlayerPrefs.SetInt("scoreE3rd", PlayerPrefs.GetInt("scoreE2nd"));
            PlayerPrefs.SetInt("scoreE2nd", generator.score);

        }
        if (PlayerPrefs.GetInt("scoreE3rd") < generator.score) ;
        {
            PlayerPrefs.SetInt("scoreE3rd", generator.score);

        }*/
    }
}
