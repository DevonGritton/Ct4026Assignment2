using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plunger : MonoBehaviour
{
    float power;
    float minPower = 0f;
    public float maxPower = 10000f;
    public Slider plungerSlider;
    List<Rigidbody> ballList;
    bool ballReady;
    void Start()
    {
        ballReady = false;
        plungerSlider.minValue = 0;
        plungerSlider.maxValue = maxPower;
        //plungerSlider.enabled = true;
        ballList = new List<Rigidbody>();
    }
    void Update()
    {
        plungerSlider.value = power;
        if (ballList.Count >= 0)
        {
            ballReady = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if(power <= maxPower)
                {
                    power += 500 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach(Rigidbody r in ballList)
                {
                    r.AddForce(power * Vector3.forward);
                }
            }
        }
        else
        {
            ballReady = false;
            power = 0f;
        }
    }





    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            plungerSlider.gameObject.SetActive(true);
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            plungerSlider.gameObject.SetActive(false);
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            power = 0f;
        }
    }
}
