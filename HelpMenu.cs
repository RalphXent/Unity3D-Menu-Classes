using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class to handle the buttons in the Help Menu
/// </summary>
public class HelpMenu : MonoBehaviour {

	// Exit button funtion (It enters to Main Menu)
    public void HandleExitButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.ClickButton);
        MenuManager.GoToMenu(MenuName.Main); //Returns to Main Menu
    }
}
