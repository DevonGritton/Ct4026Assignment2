using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    [SerializeField]
    public Transform leftpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
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

        transform.RotateAround(leftpoint.transform.position, leftpoint.transform.up, -300 * Time.deltaTime);
        //rotationvalues = Mathf.Clamp(rotationvalues, VerticalMinMax.x, VerticalMinMax.y);
    }
    void down()
    {
        transform.RotateAround(leftpoint.transform.position, leftpoint.transform.up, 300 * Time.deltaTime);
    }

}
