using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    private Text scoreText;
    private int scoreCount;
    [SerializeField] private ScoreSystem scoreSystem;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Money")
        {
            Destroy(collision.gameObject);
            scoreSystem.Score += 1;
        }
    }
}
