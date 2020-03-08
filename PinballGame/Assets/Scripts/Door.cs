using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool Active;
    float counter;
    [SerializeField]
    GameObject door;
    void Start()
    {
        Active = false;
        counter = 1.5f;
    }
    void Update()
    {
        if (Active)
        {
            door.SetActive(false);
            counter -= Time.deltaTime;
        }
        if (counter <= 0)
        {
            door.SetActive(true);
            Active = false;
            counter = 1.5f;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Active = true;
        }
    }
}
