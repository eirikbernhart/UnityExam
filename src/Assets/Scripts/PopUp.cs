using UnityEngine;
using System.Collections;

public class PopUp : MonoBehaviour
{

    private GameObject monster;
    Animator anim;
    private AudioSource aud;



    void Start()
    {
        monster = GameObject.Find("Monster1");
        anim = monster.GetComponent<Animator>();
        aud = monster.GetComponent<AudioSource>();

    }


    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "TriggerCube1")
        {
            anim.enabled = true;
            aud.Play();
        }
    }
}
