using UnityEngine;

public class GoalTriggerUpper : MonoBehaviour {

    private GoalTriggerLower lowerTrigger;

    private void Awake ()
    {
        lowerTrigger = GetComponentInChildren<GoalTriggerLower> ();
    }

	private void OnTriggerEnter (Collider other)
    {
        lowerTrigger.ExpectCollider (other);
    }

}
