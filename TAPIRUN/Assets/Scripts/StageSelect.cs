using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour
{
    public RectTransform stRT;
    float selectorX = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stRT.localPosition = new Vector3(selectorX, 0, 0);
        if (Input.GetKeyDown("left")) STMoveToLeft();
        if (Input.GetKeyDown("right")) STMoveToRight();
    }

    public void STMoveToLeft()
    {
        if(selectorX < 0.0f)
        {
            selectorX += 1920f;
        }

    }

    //
    public void STMoveToRight()
    {
        if (selectorX > -3840.0f)
        {
            selectorX -= 1920f;
        }
        
    }
}
