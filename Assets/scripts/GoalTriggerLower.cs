using UnityEngine;

public class GoalTriggerLower : MonoBehaviour {

    private Collider expectedCollider;
    private GvrAudioSource source;

    private void Awake ()
    {
        source = GetComponent<GvrAudioSource> ();
    }

    public void ExpectCollider (Collider other)
    {
        expectedCollider = other;
    }

	private void OnTriggerEnter (Collider other)
    {
        if (other == expectedCollider)
        {
            ScoreManager.Instance.AddToScore ();
            source.PlayOneShot(source.clip);
        }
    }

}
