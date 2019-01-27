using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Class to handle the Menu when the player dies.
/// </summary>
public class GameOverMenu : MonoBehaviour {
	//Define variables
    Text scoreText;
    Player score;

    // Use this for initialization
    void Start()
    {
        AudioManager.Play(AudioClipName.GameOver); //Play GameOver Sound effect
        Time.timeScale = 0; //Stop game from running
        scoreText = GameObject.FindGameObjectWithTag("GameOverScore").GetComponent<Text>(); //Reference scoreText
        score = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>(); //Reference score
        scoreText.text = "Score:   " + score.score; //Update score
    }

	// Restart button function
    public void HandleRestartButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
        Time.timeScale = 1; //Game starts running again
        Destroy(gameObject); //Destroy GameOver Menu
        SceneManager.LoadScene("Gameplay"); //Load Gameplay Scene again
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
