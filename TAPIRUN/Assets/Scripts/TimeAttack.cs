using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAttack : MonoBehaviour
{
    public TapiokaController tapioka;
    public StageGenerator generator;
    public RectTransform taRT;
    public RectTransform tardRT;
    float tapositionY = -1200;
    public Text timerText;
    public Text distanceText;
    float timer = 0;

    bool IsStun()
    {
        return generator.score >= 500;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tardRT.localPosition = new Vector3(0, tapositionY, 0);
        timer += Time.deltaTime;
        taRT.localPosition = new Vector3(generator.score - 500, 50, 0);
        timerText.text = "Œo‰ßŽžŠÔ : " + (int)timer + "•b";
        distanceText.text = "‹——£" + generator.score + "m";

        if (IsStun())
        {
            //
            tapioka.moveDirection.x = 0.0f;
            tapioka.moveDirection.z = 0.0f;
        }

        if (generator.score >= 500)
        {
            //
            Invoke("ResultDisplay", 1.0f);

            //enabled = false;


        }
    }

    void ResultDisplay()
    {
        tapositionY = 0;

    }
}
