using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public Transform launchPoint;
    public Transform Target;
    public GameObject[] ActiveBall;


    [SerializeField]
    private float BallSpeed = 40.0f;

    [SerializeField]
    public GameObject Ball;

    private void fire()
    {
        GameObject launch = Instantiate(Ball, launchPoint.position, launchPoint.rotation * Quaternion.Euler(90f, 0f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        ActiveBall = GameObject.FindGameObjectsWithTag("Ball");
        if (ActiveBall.Length == 0)
        {
            fire();
        }
    }
}
