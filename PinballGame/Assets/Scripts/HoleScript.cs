using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    bool hit;
    bool ricoshet;
    public Health healthbar;
    public float timer;
    public void Start()
    {
        timer = 2.0f;
        healthbar.SetMaxHealth(maxHealth);
        maxHealth = currentHealth;
        hit = false;
        ricoshet = false;
    }             
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            hit = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ricoshet = true;
    }
    void Update()
    {
        if (hit == true && ricoshet == false)
        {
            Damage(1);
            hit = false;               
        }
        if (ricoshet == true)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            ricoshet = false;
            timer = 2.0f;
        }

    }
    void Damage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
}
