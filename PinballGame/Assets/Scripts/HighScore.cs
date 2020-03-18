using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text TopScore;
    // Start is called before the first frame update
    void Start()
    {
        TopScore.text = PlayerPrefs.GetInt("UserScore",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreScript.ScoreValue > PlayerPrefs.GetInt("UserScore", 0))
        {
            
            PlayerPrefs.SetInt("UserScore", ScoreScript.ScoreValue);
            TopScore.text = ScoreScript.ScoreValue.ToString();
        }
        
    }
}
