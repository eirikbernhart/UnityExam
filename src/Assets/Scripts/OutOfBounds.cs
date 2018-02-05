using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class OutOfBounds : MonoBehaviour {

    public Canvas failMenu;
    public Button restartButton;
    public Button mainMenuButton;

    void Start () {
	    failMenu.enabled = false;
	}
	
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "OutOfBounds")
        {
            Time.timeScale = 0;
            failMenu.enabled = true;
        }
    }
}
