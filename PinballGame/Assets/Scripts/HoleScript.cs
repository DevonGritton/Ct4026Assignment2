using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            Health.HpValue -= 1;
        }
        else
        {
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
