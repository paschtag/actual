using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemanager : MonoBehaviour
{
    public void IntroGame()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void HighScores()
    {
        SceneManager.LoadScene("2HighScores");
    }
    public void startGame()
    {
        SceneManager.LoadScene("3Game");
    }
    public void ExitScene()
    {
        SceneManager.LoadScene("4Exit");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
