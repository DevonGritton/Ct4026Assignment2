using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Health.HpValue <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
