using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MonsterHazard : MonoBehaviour {

    public Canvas failMenu;
    public Button restartButton;
    public Button mainMenuButton;
    public Canvas win;
    public Canvas info;

    // Use this for initialization
    void Start () {

        failMenu.enabled = false;
        win.enabled = false;
        info.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Monster")
        {
            Time.timeScale = 0;
            failMenu.enabled = true;
        }
    }
}
