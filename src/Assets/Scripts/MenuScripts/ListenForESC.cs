using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ListenForESC : MonoBehaviour {

    public Canvas pauseMenu;
    public Button resumeButton;
    public Button mainMenuButton;
    public Canvas failMenu;
    private Screen screen;

    CursorLockMode wantedMode;
    private string sceneName;


    // Use this for initialization
    void Start () {
        pauseMenu.enabled = false;
        failMenu.enabled = false;

        //Cursor.lockState = wantedMode;
        //Cursor.visible = true;



    }

    // Update is called once per frame
    void Update () {
	    if(Input.GetKeyDown(KeyCode.Escape))
        {
            failMenu.enabled = false;
            pauseMenu.enabled = true;
            Time.timeScale = 0;
        }
	}

    public void Resume()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1;
    }

    public void Restart()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
