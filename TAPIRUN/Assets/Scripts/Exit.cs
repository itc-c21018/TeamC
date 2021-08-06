using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public float GetoutTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,GetoutTime);
    }

}
