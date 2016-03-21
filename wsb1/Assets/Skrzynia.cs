using UnityEngine;
using System.Collections;

public class Skrzynia : MonoBehaviour {
	public GameObject eksplozja;
	void trafiony() 
	{
		Destroy(gameObject);
		GameObject go;
		go = Instantiate(eksplozja, transform.position, transform.rotation) as GameObject; 
		Destroy(go, 1.0f);
	}
}
