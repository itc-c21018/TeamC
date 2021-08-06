using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float EspeedX;
    public float EspeedY;
    public float EspeedZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float EX = this.transform.position.x;
        EX += EspeedX * 0.01f;

        float EY = this.transform.position.y;
        EY += EspeedY * 0.01f;

        float EZ = this.transform.position.z;
        EZ += EspeedZ * 0.01f;

        transform.position = new Vector3(EX, EY, EZ);
    }
}
