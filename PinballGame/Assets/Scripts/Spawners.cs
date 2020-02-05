﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public Transform launchPoint;
    public Transform Target;

    [SerializeField]
    private float BallSpeed = 1000.0f;

    [SerializeField]
    public GameObject Ball;

    [SerializeField]
    public GameObject Gate;

    [SerializeField]
    public float countdown = 5f;

    [SerializeField]
    private float delay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Gate.SetActive(true);
    }
    private void fire()
    {
        GameObject SpawnBall = Instantiate(Ball, launchPoint.position, launchPoint.rotation);
        Rigidbody rbBall = SpawnBall.GetComponent<Rigidbody>();
        if (Ball != null)
        {
            Vector3 dirToTarget = Target.position - rbBall.position;
            dirToTarget.Normalize();

            rbBall.velocity = dirToTarget * BallSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        delay += Time.deltaTime;
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            fire();
            delay = 0f;
            countdown = 5f;
        }
        if (delay <= 2)
        {
            Gate.SetActive(false);
        }
        else
        {
            Gate.SetActive(true);
        }
    }
}
