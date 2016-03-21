using UnityEngine;
using System.Collections;
public class Karabin : MonoBehaviour {
	
	public ParticleSystem ps;
	public AudioClip dzwiek;
	private RaycastHit hit;
	private Vector3 fwd;
	void Start ()
	{
		GetComponent<AudioSource>().clip = dzwiek;

	}

	void Update () 
	{
		fwd = transform.TransformDirection(Vector3.forward);
		if (Input.GetButtonDown ("Fire1")) {
			ps.Play ();
			GetComponent<AudioSource> ().Play ();

			if (Physics.Raycast (transform.position, fwd, out hit)) {
				if (hit.transform.tag == "Wrog") {
					hit.transform.gameObject.SendMessage ("trafiony");	
			}
			}
		}
	}


}
