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

    public void OnStartButtonClicked1()//�X�e�[�W�Z���N�g��ʂɈړ�
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OnStartButtonClicked2()//�Q�[�����E�Ɉړ�
    {
        SceneManager.LoadScene("Endless");
    }

    public void OnStartButtonClicked3()//�Q�[�����T�Ɉړ�
    {
        SceneManager.LoadScene("TimeAttack");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
