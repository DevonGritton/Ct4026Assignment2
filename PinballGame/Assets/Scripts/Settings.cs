using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    float brightness;
    public Text display;
    float score;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        // Loads the value the player selected for the brightness in the options menu
        //And applies it to the current scene
        brightness = PlayerPrefs.GetFloat("UserBrightness", 0);
        RenderSettings.ambientLight = new Color(brightness, brightness, brightness, 1);//asigns the value selected from the options slider to the current settings brightness options
        PlayerPrefs.SetFloat("UserBrightness", brightness);

        score = PlayerPrefs.GetFloat("UserScore");
        // display.text = score.ToString();

        slider.value = Health.CurrentHealth;
        slider.onValueChanged.AddListener(OnSliderHealthChanged);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("Level2");
        }
    }   

    void OnSliderHealthChanged(float a_value)
    {
        Health.CurrentHealth = (int)a_value;
    }
}