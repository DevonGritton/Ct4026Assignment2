using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Health.HpValue -= 1;
        }
        else
        {
            return;
        }
    }
}
