﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 0;                                       

    void Update()
    {                                                         
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
        if (score > PlayerPrefs.GetInt("HighScore"))
        {                      
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
    void Awake()
    {                                                            
        // If the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("HighScore"))
        {                               
            score = PlayerPrefs.GetInt("HighScore");
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("HighScore", score);                            
    }

}