using UnityEngine;

public class Ball : MonoBehaviour {

    private GvrAudioSource source;
    private Rigidbody rb;

    private void Awake ()
    {
        source = GetComponent<GvrAudioSource> ();
        rb = GetComponent<Rigidbody> ();
    }

	private void OnCollisionEnter (Collision other)
    {
        float volume = Mathf.Min (rb.velocity.magnitude / 10, 1);
        source.PlayOneShot(source.clip, volume);
    }

}
