using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsRight : MonoBehaviour
{
    [SerializeField]
    public Transform rightpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void right()
    {
        transform.RotateAround(rightpoint.transform.position, rightpoint.transform.up, 300 * Time.deltaTime);
    }
    void down()
    {
        transform.RotateAround(rightpoint.transform.position, rightpoint.transform.up, -300 * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
         {
             right();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            down();
        }
    }
}
