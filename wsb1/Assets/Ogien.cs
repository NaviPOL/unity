using UnityEngine;
using System.Collections;

public class Ogien : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Toolbox.Instance.zycie -= 5;
        }
    }
}
