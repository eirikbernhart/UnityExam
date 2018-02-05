using UnityEngine;
using System.Collections;

public class Finished : MonoBehaviour {

    private GameObject go;
    private AudioSource tada;
    public Canvas win;

    // Use this for initialization
    void Start () {

        go = GameObject.Find("Finish");
        tada = go.gameObject.GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Princess")
        {
            tada.Play();
            win.enabled = true;

        }
    }

  
}
