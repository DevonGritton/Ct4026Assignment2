using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Plunger : MonoBehaviour
{
    float Power;
    public float maxPower = 10000f;
    public Slider plungerSlider;
    List<Rigidbody> ballList;
    public GameObject plungerstop;
    public bool DragEnd = false;
    public bool change = false;
    public bool inrange = false;
    void Start()
    {
        plungerSlider.maxValue = maxPower;
        plungerSlider.gameObject.SetActive(false);
        ballList = new List<Rigidbody>();
        
    }
    void Update()
    {

        if (ballList.Count >= 0)
        {
           // if (Input.GetKey(KeyCode.Space))
           // {
            //    if(power <= maxPower)
           //    {
            //        power += 500 * Time.deltaTime;
           //     }
           // }
            if (DragEnd)
            {
                foreach(Rigidbody r in ballList)
                {
                    r.AddForce(plungerSlider.value * Vector3.forward);
                    plungerSlider.value = 0.0f;
                    DragEnd = false;
                }
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            inrange = true;
            plungerSlider.gameObject.SetActive(true);
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            plungerstop.gameObject.SetActive(false);
            plungerSlider.gameObject.SetActive(false);
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            Power = 0f;
            inrange = false;
        }
    }
    public void PlungerValue(float power)
    {
        if (change)
        {
        plungerSlider.value = power;
        }

    }
 
}
