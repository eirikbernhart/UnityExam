using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadNextLevelTrigger : MonoBehaviour {

    private AudioSource aud;
    private GameObject go;

    void Start () {

        go = GameObject.Find("FPSController");
        aud = go.GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "LoadNextLevel")
        {
            SceneManager.LoadScene(2);
            aud.enabled = true;
        }
    }
}
