using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    // public AudioObject audioObject;
    public int score;
        void Start()
    {
      UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void tambahScore()
    {
       score++;
    }
}
