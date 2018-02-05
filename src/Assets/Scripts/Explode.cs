using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

    private GameObject monsterKing;
    private GameObject[] monsters;
    public GameObject explodeParent;

    


    void Start () {
        monsterKing = GameObject.Find("MonsterKing");
        monsters = GameObject.FindGameObjectsWithTag("Monster");

        
    }
	
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Monster")
        {
            explodeParent.SetActive(true);
            Destroy(monsterKing);
            foreach(GameObject monster in monsters)
            {
                Destroy(monster);
            }
        }
    }
}
