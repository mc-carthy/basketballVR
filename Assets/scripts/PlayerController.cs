using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]
    private GameObject ballPrefab;

    private Camera cam;
    private Vector3 ballOffset = new Vector3 (0, -1, 2);
    private float ballLaunchAngleOffsetDeg = 45f;
    private float ballSpeed = 12.5f;

    private void Awake ()
    {
        cam = GetComponentInChildren<Camera> ();
    }

    private void Update ()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            LaunchBall ();
        }
    }

    private void LaunchBall ()
    {
        GameObject ball = Instantiate (ballPrefab);
        Rigidbody ballRb = ball.GetComponent<Rigidbody> ();
        ball.transform.position = transform.position + ballOffset;
        float launchAngleRad = ballLaunchAngleOffsetDeg * Mathf.Deg2Rad;
        Vector3 ballLaunchAngle = Vector3.RotateTowards (cam.transform.forward, Vector3.up, launchAngleRad, 0);
        ballLaunchAngle *= ballSpeed;
        ballRb.velocity = ballLaunchAngle;
    }

}
