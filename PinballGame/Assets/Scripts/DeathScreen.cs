using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public Health healthbar;
    public void Update()
    {
       if (Health.CurrentHealth <= 0)
        {
            back();
        }  
    }

    public void back()
    {
        SceneManager.LoadScene("GameOver");
    }
}
