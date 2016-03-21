using UnityEngine;
using System.Collections;
public class Karabin : MonoBehaviour {

	public Texture2D celownik;
	public ParticleSystem ps;
	public AudioClip dzwiek;
	private Rect position;
	private RaycastHit hit;
	private Vector3 fwd;
	void Start ()
	{
		GetComponent<AudioSource>().clip = dzwiek;
		position = new Rect((Screen.width - celownik.width) / 2,
		                    (Screen.height - celownik.height) /2,
		                    celownik.width,
		                    celownik.height);

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
		
	void OnGUI()
	{
		GUI.DrawTexture(position, celownik);
	}


}
