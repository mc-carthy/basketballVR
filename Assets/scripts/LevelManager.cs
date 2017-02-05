using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : Singleton<LevelManager> {

	public void LoadNextScene ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }

    public void QuitGame ()
    {
        Application.Quit ();
    }

}
