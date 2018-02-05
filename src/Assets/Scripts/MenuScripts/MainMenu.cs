using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Canvas startMenu;
    public Canvas levelSelectMenu;
    public Button levelSelectButton;
    public Button exitButton;

    private AudioSource aud;

    // Use this for initialization
    void Start () {
        levelSelectMenu.enabled = false;
        aud = levelSelectMenu.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LevelSelect()
    {
        aud.Play();
        levelSelectMenu.enabled = true;
        startMenu.enabled = false;
    }

    public void Mainmenu()
    {
        levelSelectMenu.enabled = false;
        startMenu.enabled = true;
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }
}
