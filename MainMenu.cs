using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class to handle the buttons in the Main Menu
/// </summary>
public class MainMenu : MonoBehaviour {

	// Play Button Function (It enters Difficulty Menu)
    public void HandlePlayButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
        MenuManager.GoToMenu(MenuName.Difficulty);
    }

	// Help button function (It enters Help Menu)
    public void HandleHelpButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
        MenuManager.GoToMenu(MenuName.Help);
    }

	// Exits the game
    public void HandleQuitButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
    }
}
