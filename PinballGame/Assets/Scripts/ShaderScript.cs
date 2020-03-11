using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour
{
    [SerializeField]
    public Material dissolveMat;
    public float MaxHealth = 3f;
    public float Health = -1f;
    public bool death;
    // Start is called before the first frame update
    void Start()
    {
        dissolveMat.SetFloat("Vector1_C42086C0", -1);
        Health = -1f;
        death = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Killbox")
        {
            death = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (death)
        {
            Health += 0.5f * Time.deltaTime;
            dissolveMat.SetFloat("Vector1_C42086C0", Health);
            
            MaxHealth -= 0.2f * Time.deltaTime;
            if (Health >= MaxHealth)
            {
                Destroy(gameObject);
                dissolveMat.SetFloat("Vector1_C42086C0", -1);
                death = false;
            }
        }
    }
}
