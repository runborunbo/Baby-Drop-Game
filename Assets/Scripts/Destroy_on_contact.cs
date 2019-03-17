using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Destroy_on_contact : MonoBehaviour
{
    AudioSource audioSource;
    public Text scoreGT;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GameObject scoreGO = GameObject.Find("ScoreCounter");              
        // Get the Text Component of that GameObject
        scoreGT = scoreGO.GetComponent<Text>();                            
        // Set the starting number of points to 0
        scoreGT.text = "0";


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy (other.gameObject);
        // Parse the text of the scoreGT into an int
        int score = int.Parse(scoreGT.text);                         

        score += 100;
        // Convert the score back to a string and display it
        scoreGT.text = score.ToString();
        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
        GetComponent<AudioSource>().Play();
    }
}
