using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : Singleton<ScoreManager> {

    [SerializeField]
    private Text timeLeftText;
    [SerializeField]
    private Text scoreText;

    private float timeLeft = 60f;
    private int score;

    private void Start ()
    {
        UpdateScore ();
    }

    private void Update ()
    {
        timeLeft -= Time.deltaTime;
        UpdateTimeLeft ();
        if (timeLeft < 0)
        {
            LevelManager.Instance.GoToMenu ();
        }
    }

	public void AddToScore (int value = 1)
    {
        score++;
        UpdateScore ();
    }

    private void UpdateScore ()
    {
        scoreText.text = "Score: " + score.ToString ();
    }

    private void UpdateTimeLeft ()
    {
        timeLeftText.text = "Time Left: " + timeLeft.ToString ("00");
    }

}
