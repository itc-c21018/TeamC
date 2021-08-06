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

    public void OnStartButtonClicked1()//ƒQ[ƒ€‰æ–Ê‚ÉˆÚ“®
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OnStartButtonClicked2()//ƒQ[ƒ€‰æ–Ê‚ÉˆÚ“®
    {
        SceneManager.LoadScene("Main");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
