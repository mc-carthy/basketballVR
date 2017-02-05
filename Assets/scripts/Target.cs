using UnityEngine;

public class Target : MonoBehaviour {

	private void OnTriggerEnter ()
    {
        ScoreManager.Instance.AddToScore();
    }

}
