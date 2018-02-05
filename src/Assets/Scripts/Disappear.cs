using UnityEngine;
using System.Collections;

public class Disappear : MonoBehaviour {

    private GameObject monster;
  
    void Start () {
         monster = GameObject.Find("Monster0");
	}
	
	
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "PlatformTrigger2")
        {
            Destroy(monster);
        }
    }
}
