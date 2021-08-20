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

    public void OnStartButtonClicked1()//ステージセレクト画面に移動
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OnStartButtonClicked2()//ゲーム画面Eに移動
    {
        SceneManager.LoadScene("Endless");
    }

    public void OnStartButtonClicked3()//ゲーム画面Tに移動
    {
        SceneManager.LoadScene("TimeAttack");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
