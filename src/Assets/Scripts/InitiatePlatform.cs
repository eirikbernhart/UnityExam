using UnityEngine;
using System.Collections;

public class InitiatePlatform : MonoBehaviour {

    private GameObject finishPlatform;
    Animator anim;
    private AudioSource aud;
    private GameObject go;
    private GameObject go2;
    public AudioSource tada;

    void Start () {

        finishPlatform = GameObject.Find("FinishPlatform");
        anim = finishPlatform.GetComponent<Animator>();
        go = GameObject.Find("FPSController");
        aud = go.GetComponent<AudioSource>();

        //Getting different audio
        go2 = GameObject.Find("FinishPlatform");
        tada = go2.gameObject.GetComponent<AudioSource>();

    }

	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "FinishPlatform")
        {
            aud.enabled = false;
            tada.enabled = true;
            anim.enabled = true;
        }
    }
}
