using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnStartButtonClicked1()//ゲーム画面に移動
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OnStartButtonClicked2()//ゲーム画面に移動
    {
        SceneManager.LoadScene("Main");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
