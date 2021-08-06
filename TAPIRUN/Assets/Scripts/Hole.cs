using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    // ry
    public string targetTag;
    bool isHolding;

    //ry
    public bool IsHolding()
    {
        return isHolding;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == targetTag)
        {
            isHolding = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            isHolding = false;
        }
    }
    void OnTriggerStay(Collider other)
    {
        //ry
        //Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        //ry
        Vector3 direction = other.gameObject.transform.position - transform.position;
        direction.Normalize();

        //ry
        if(other.gameObject.tag == targetTag)
        {
            //ry
            //r.velocity *= 0.9f;
            //r.AddForce(direction * -20.0f, ForceMode.Acceleration);

        }
    }
}
