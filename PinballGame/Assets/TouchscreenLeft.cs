﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchscreenLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;
    public string inputName;
    public bool Lactive;

    public HingeJoint hinge;
    // Start is called before the first frame updaste

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;


        hinge.useLimits = true;
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        JointSpring spring = hinge.spring;
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (Lactive == true)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hinge.spring = spring;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Lactive = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Lactive = false;
    }
}


