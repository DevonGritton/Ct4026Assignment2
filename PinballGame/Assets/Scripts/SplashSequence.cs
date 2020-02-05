using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSequence : MonoBehaviour
{
    public static int SceneNo;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneNo == 0)
        {
            StartCoroutine(ToSplash2());//On start if the player is on the first scene it will begin the sequence to the next scene
        }
        if (SceneNo == 1)
        {
            StartCoroutine(ToSplash3());//On start if the player is on the first scene it will begin the sequence to the next scene
        }
        if (SceneNo == 2)
        {
            StartCoroutine(ToMainMenu());
        }
    }
    IEnumerator ToSplash2()
    {
        yield return new WaitForSeconds(5);
        SceneNo = 1;//after 5 seconds the next splash will appear 
        SceneManager.LoadScene(1);
    }
    IEnumerator ToSplash3()
    {
        yield return new WaitForSeconds(5);
        SceneNo = 2;//after 5 seconds the next splash will appear 
        SceneManager.LoadScene(2);
    }
    IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(5);
        SceneNo = 3;//after 5 seconds the next splash will appear 
        SceneManager.LoadScene(3);
    }
}
