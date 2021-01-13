using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreHandler : MonoBehaviour
{
    int newScore = 0;

    private Text label;

    void Awake()
    {
        label = GetComponent<Text>();
        //PlayerPrefs.SetInt("highscore", 0);
    }

    public void setScore(string score)
    {
        newScore = int.Parse(score);

        //New HighScore
        if (newScore > PlayerPrefs.GetInt("highscore") | PlayerPrefs.GetInt("highscore") == 0)
        {
            label.color = Color.green;
            label.text = "Highscore: " + newScore;

            PlayerPrefs.SetInt("highscore", newScore);
        }
        //Previous HighScore
        else
        {
            label.color = Color.red;
            label.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
        }

        
    }
}
