using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;
    public Gradient Gradient;
    public Image fill;

    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = Gradient.Evaluate(slider.normalizedValue);
    }
    public void SetMaxHealth(int health)
    {
        slider.value = health;
        slider.value = health;

        fill.color = Gradient.Evaluate(1f);
    }
}
