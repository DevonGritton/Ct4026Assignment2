using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField]
    GameObject Effect;
    private void OnCollisionEnter(Collision other) // will call when the object collides with another
    {
        if (other.collider.CompareTag("Ball"))
        {
            Instantiate(Effect, transform.position, transform.rotation);//activates the assigned particle effect
        }
    }
private void OnTriggerEnter(Collider other)
    {
        ScoreScript.ScoreValue += 1;
    }
}
