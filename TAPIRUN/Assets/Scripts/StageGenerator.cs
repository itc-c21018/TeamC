using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageGenerator : MonoBehaviour
{
    int StageChipSize = 30;

    int currentChipIndex;
    public int level = 1;

    public Transform character;
    public GameObject[] stageChips;
    public int startChipIndex;
    public int preInstantiate;
    public int levelUpIndex;
    public int score;
    public int speedlevel;
    public float gravitylevel;
    public Text levelText;
    public Text scoreText;
    public List<GameObject> generatedStageList = new List<GameObject>();
    public GUIStyle textStyle;

    GameObject tapioka;

    TapiokaController script;

    // Start is called before the first frame update
    void Start()
    {
        tapioka = GameObject.Find("Tapioka");
        script = tapioka.GetComponent<TapiokaController>();

        currentChipIndex = startChipIndex - 1;
        UpdateStage(preInstantiate);
    }

    // Update is called once per frame
    void Update()
    {
        speedlevel = level - 1;
        gravitylevel = (float)level * 0.1f;
        //
        int charaPositionIndex = (int)(character.position.z / StageChipSize);
        
        score = (int)(character.position.z + script.scoreindex);
        //
        if (charaPositionIndex + preInstantiate > currentChipIndex)
        {
            UpdateStage(charaPositionIndex + preInstantiate);
        }

        levelText.text = "LEVEL : " + level;
        scoreText.text = "スコア : " + score + "m";

        //理想：キャラの進んだ距離が一定以上になると
        if(charaPositionIndex / levelUpIndex >= level)
        {
            level ++;
        }
    }

    /*void OnGUI()
    {
        GUI.color = Color.black;

        GUI.Label(new Rect(50, 65, 100, 30),"LEVEL" + level,textStyle);

        //スコア
        int score = (int)(character.position.z + script.scoreindex);

        GUI.color = Color.black;

        GUI.Label(new Rect(50, 120, 100, 30), "スコア" + score + "ｍ", textStyle);

    }*/

    //
    void UpdateStage(int toChipIndex)
    {
        if (toChipIndex <= currentChipIndex) return;

        //
        for(int i = currentChipIndex + 1;i <= toChipIndex; i++)
        {
            GameObject stageObject = GenerateStage(i);

            //
            generatedStageList.Add(stageObject);
        }

        //
        while (generatedStageList.Count > preInstantiate + 2) DestroyOldestStage();

        currentChipIndex = toChipIndex;
    }

    //
    GameObject GenerateStage(int chipIndex)
    {
        int nextStageChip = Random.Range(0, stageChips.Length);

        GameObject stageObject = (GameObject)Instantiate(
            stageChips[nextStageChip],
            new Vector3(0, 0, chipIndex * StageChipSize),
            Quaternion.identity
        );

        return stageObject;
    }

    //
    void DestroyOldestStage()
    {
        GameObject oldStage = generatedStageList[0];
        generatedStageList.RemoveAt(0);
        Destroy(oldStage);
    }
}
