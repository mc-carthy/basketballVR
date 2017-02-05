public class ScoreManager : Singleton<ScoreManager> {

    private int score;

	public void AddToScore (int value = 1)
    {
        score++;
    }

}
