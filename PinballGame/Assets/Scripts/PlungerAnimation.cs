using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerAnimation : MonoBehaviour
{
    public Slider slider;
    private Animator animator;
    private float timer;
    public GameObject plungerstop;
    public Plunger Plunger;
   
    // Start is called before the first frame update
    void Start()
    {
        plungerstop.gameObject.SetActive(true);
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Plunger.inrange == true)
        {
            plungerstop.gameObject.SetActive(true);
        }
        else
        {
            plungerstop.gameObject.SetActive(false);
        }
    }
    public void OnRelease()
    {
        timer -= 0.1f * Time.deltaTime;
        animator.Play("PlungerGoingDown",0,timer);
        plungerstop.gameObject.SetActive(false);
    }
    public void OnValueChanged()
    {
        animator.Play("PlungerGoingBack", -1, slider.normalizedValue);
    }
    
}
