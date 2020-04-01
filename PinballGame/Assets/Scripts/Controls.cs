using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    [SerializeField]
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;
    public string inputName;

    public HingeJoint hinge = null;
    // Start is called before the first frame updaste

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        
       
        hinge.useLimits = true;
    }
    // Update is called once per frame
    void Update()
    {
        JointSpring spring = hinge.spring;
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hinge.spring = spring;
    }
   public void left()
    {
        JointSpring spring = hinge.spring;
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hinge.spring = spring;
        // JointSpring spring = hinge.spring;
        // spring.spring = hitStrength;
        // spring.damper = flipperDamper;

        //spring.targetPosition = pressedPosition;

        // hinge.spring = spring;

    }
   public void down()
    {
        JointSpring spring = hinge.spring;
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hinge.spring = spring;
        //  JointSpring spring = hinge.spring;
        // spring.spring = hitStrength;
        // spring.damper = flipperDamper;

        //spring.targetPosition = pressedPosition;

        // hinge.spring = spring;
    }

}
