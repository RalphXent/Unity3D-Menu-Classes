using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class to handle the Pause Menu
/// </summary>
public class PauseMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 0; // Stops the game
    }

	// Resume button function
    public void HandleResumeButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
        Time.timeScale = 1; //Resumes the game
        Destroy(gameObject); //Destroy Pause Menu
    }

	// Exit Button function
    public void HandleExitButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.Main); //Returns to Main Menu
    }
}
