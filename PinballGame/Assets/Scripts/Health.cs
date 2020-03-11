using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;
    public Gradient Gradient;
    public Image fill;

    public static int CurrentHealth;
    private void Start()
    {
        //SetHealth(20);
    }
    private void Awake()
    {
        slider.onValueChanged.AddListener(OnSliderChanged);
    }

    private void OnSliderChanged(float a_value)
    {
        //SetHealth((int)a_value);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = Gradient.Evaluate(slider.normalizedValue);
    }
    public void SetMaxHealth(int health)
    {
        slider.value = health;
        fill.color = Gradient.Evaluate(1f);
    }
}
