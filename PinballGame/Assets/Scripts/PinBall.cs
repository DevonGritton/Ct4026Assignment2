using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bumper")
        {
            Destroy(gameObject);
            ScoreScript.ScoreValue += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
