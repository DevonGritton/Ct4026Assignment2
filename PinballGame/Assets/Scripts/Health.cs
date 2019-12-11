using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    Text health;
    public static int HpValue = 10;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        health.text = HpValue.ToString();
    }
}
