using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    private Text scoreText;
    private int scoreCount;
    public int Score
    {
        get { return scoreCount; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("Количество очков не может быть отрицательным");
                value = 0;
            }
            scoreCount = value;
            scoreText.text = "Монеты: " + scoreCount;
        }
    }
    void Start()
    {
        scoreText = GetComponent<Text>();
    }


    void Update()
    {
        
    }
}
