using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : Singleton<ScoreManager> {

    [SerializeField]
    private Text timeLeftText;
    [SerializeField]
    private Text scoreText;

    private float initialTimeLeft = 60f;
    private float timeLeft;
    private int score;

    private void Start ()
    {
        if (SceneManager.GetActiveScene ().name == "main")
        {
            timeLeft = initialTimeLeft;
            UpdateScore ();
        }
    }

    private void Update ()
    {
        if (SceneManager.GetActiveScene ().name == "main")
        {
            UpdateTimer ();
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

    private void UpdateTimer ()
    {
        timeLeft -= Time.deltaTime;
        UpdateTimeLeft ();
        if (timeLeft < 0)
        {
            LevelManager.Instance.GoToMenu ();
        }
    }

}
