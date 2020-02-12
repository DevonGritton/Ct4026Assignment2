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

    private HingeJoint hinge = null;
    // Start is called before the first frame update

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
        if (Input.GetKey(KeyCode.W))
        {
            left();   
        }
        else if(Input.GetKey(KeyCode.S))
        {
            down();
        }
    }
    void left()
    {

        //transform.RotateAround(leftpoint.transform.position, leftpoint.transform.up, -300 * Time.deltaTime);
        //rotationvalues = Mathf.Clamp(rotationvalues, VerticalMinMax.x, VerticalMinMax.y);
    }
    void down()
    {
        //transform.RotateAround(leftpoint.transform.position, leftpoint.transform.up, 300 * Time.deltaTime);
    }

}
