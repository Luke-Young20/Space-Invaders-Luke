using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("GameScreen");

    }

    public void AchievementsButton()
    {
        SceneManager.LoadScene("AchievementsScreen");

    }
    public void InstructionsButton()
    {
        SceneManager.LoadScene("InstructionsScreen");

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
