using UnityEngine;
using System.Collections;

public class Wrog : MonoBehaviour {
	
	// Use this for initialization
	public Transform cel;
	public Transform cel2;
	public Transform gracz;
	public Transform wrog;
	private NavMeshAgent agent;
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		agent.SetDestination (cel.position);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag.Equals("1")) {
			agent.SetDestination (cel2.position);
		}
		if(other.tag.Equals("2")) {
			agent.SetDestination (cel.position);
		}
	}
	
	void Update ()
	{
		if (Vector3.Distance (gracz.transform.position, wrog.transform.position) < 10) {
				agent.SetDestination (gracz.position);
		}
	}
}
