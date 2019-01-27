using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Class to handle the Win Menu
/// </summary>
public class WinMenu : MonoBehaviour {

	// Define variables
    Text scoreText;
    Player score;

    // Use this for initialization
    void Start()
    {
        AudioManager.Play(AudioClipName.GameOver); //Play win sound effect
        Time.timeScale = 0; // Stops the game
        scoreText = GameObject.FindGameObjectWithTag("WinScore").GetComponent<Text>(); //Reference scoreText
        score = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>(); //Reference score
        scoreText.text = "Score:   " + score.score; //Update score
    }

	// Restart button function
    public void HandleRestartButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
        Time.timeScale = 1;
        Destroy(gameObject);
        SceneManager.LoadScene("Gameplay"); // Restarts the game
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
