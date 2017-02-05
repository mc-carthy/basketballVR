using UnityEngine;

public class GoalTriggerLower : MonoBehaviour {

    private Collider expectedCollider;

    public void ExpectCollider (Collider other)
    {
        expectedCollider = other;
    }

	private void OnTriggerEnter (Collider other)
    {
        if (other == expectedCollider)
        {
            ScoreManager.Instance.AddToScore ();
        }
    }

}
