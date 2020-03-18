using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField]
    GameObject Effect;
    [SerializeField]
    GameObject text;
    GameObject ball;
    int streak = 0;
    private void OnCollisionEnter(Collision other) // will call when the object collides with another
    {
        if (other.collider.CompareTag("Ball"))
        {
            Instantiate(Effect, transform.position, transform.rotation);//activates the assigned particle effect
        }
    }
private void OnTriggerEnter(Collider other)
    {
        streak += 1;
        ScoreScript.ScoreValue += 1;
            TextPopUp();
        
    }
    void Update()
    {
        if (ball == null)
        {
            streak = 0;
        }
    }
    void TextPopUp()
    {
        var pop = Instantiate(text, transform.position, Quaternion.identity, transform);
        pop.GetComponent<TextMesh>().text = streak.ToString();
    }
}
