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
                Debug.LogError("���������� ����� �� ����� ���� �������������");
                value = 0;
            }
            scoreCount = value;
            scoreText.text = "������: " + scoreCount;
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
