using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    private GameObject coin;
    private AudioSource aud;

	
	void Start () {
        coin = GameObject.Find("Coins");
        aud = coin.GetComponent<AudioSource>();
    }
	
	
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
            aud.Play();
            
            
        }
    }
}
