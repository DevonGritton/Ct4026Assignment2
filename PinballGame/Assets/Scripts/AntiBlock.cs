using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiBlock : MonoBehaviour
{
    bool Active;
    float counter;
    [SerializeField]
    GameObject door;
    void Start()                               
    {
        Active = true;
    }
    void Update()
    {
        if (Active)
        {
            door.SetActive(true);
        }
        if (Active == false)
        {
            door.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Active = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Active = false;
        }
    }
}
