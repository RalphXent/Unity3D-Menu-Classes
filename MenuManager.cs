using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class to handle the Menus
/// </summary>
public static class MenuManager
{
    public static void GoToMenu(MenuName name)
    {
		// Define every case when a Menu is needed
        switch (name)
        {
			// If Main Menu is called then load it
            case MenuName.Main:
                SceneManager.LoadScene("MainMenu");
                break;
			// If Help Menu is called then load it
            case MenuName.Help:
                SceneManager.LoadScene("HelpMenu");
                break;
            // If Difficulty Menu is called then load it
			case MenuName.Difficulty:
                SceneManager.LoadScene("DifficultyMenu");
                break;
            // If Pause Menu is called then load it
			case MenuName.Pause:
				// If there is not any Pause Menu in the Scene, then Instantiate a Pause Menu
                if (!GameObject.FindGameObjectWithTag("PauseMenu"))
                {
                    Object.Instantiate(Resources.Load("PauseMenu"), GameObject.FindGameObjectWithTag("Canvas").transform);
                }
                break;
            // If you win the game then load Win Menu
			case MenuName.Win:
				// If there is not any Win Menu in the Scene, then Instantiate a Win Menu
                if (!GameObject.FindGameObjectWithTag("WinMenu"))
                {
                    Object.Instantiate(Resources.Load("WinMenu"), GameObject.FindGameObjectWithTag("Canvas").transform);
                }
                break;
			// If you lose the game then load Game Over Menu
            case MenuName.GameOver:
				// If there is not any Game Over Menu in the Scene, then Instantiate a Game Over Menu
                if (!GameObject.FindGameObjectWithTag("GameOverMenu"))
                {
                    Object.Instantiate(Resources.Load("GameOverMenu"), GameObject.FindGameObjectWithTag("Canvas").transform);
                }
                break;
        }
    }
}
