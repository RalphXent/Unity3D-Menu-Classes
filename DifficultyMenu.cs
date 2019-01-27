using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the Difficulty Menu
/// Difficulty = 1 = Easy
/// Difficulty = 2 = Normal
/// Difficulty = 3 = Hard
/// </summary>
public class DifficultyMenu : MonoBehaviour {
    
	// Load Easy game function
    public void HandleEasyButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton); //Play click sound effect
        ConfigurationUtils.Difficulty = 1; //ConfigurationUtils class where is defined every variable of the game
        SceneManager.LoadScene("Gameplay"); //Load Gameplay
    }

	// Load Normal game function
    public void HandleNormalButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
        ConfigurationUtils.Difficulty = 2;
        SceneManager.LoadScene("Gameplay");
    }

	// Load Hard game function
    public void HandleHardButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
        ConfigurationUtils.Difficulty = 3;
        SceneManager.LoadScene("Gameplay");
    }
}
