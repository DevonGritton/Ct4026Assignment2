using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    Text score;
   
    public static int ScoreValue = 10;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ScoreValue.ToString();
    }

    void Score()
    {
        PlayerPrefs.SetInt("UserScore", ScoreValue);
    }

}
