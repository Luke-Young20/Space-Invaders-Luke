using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour
{
    public static TMP_Text ScoreText;
    public static int score = 0;


    public void Awake()
    {
        // DontDestroyOnLoad(this);
        ScoreText = GetComponent<TMP_Text>();
    }
    public static void updateScore()
    {

    //    score++;
    //    ScoreText.text = "Score:" + score;
    }

    public static int GetScore()
    {
        return score;

    }

}