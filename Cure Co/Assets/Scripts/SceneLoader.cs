using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ToTitleScreen()
    {
        SceneManager.LoadScene(0);
    }
    public void ToNormalLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void ToHardLevel()
    {
        SceneManager.LoadScene(3);
    }
    public void ToEpicLevel()
    {
        SceneManager.LoadScene(4);
    }
    public void RestartLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void ToHowTo()
    {
        SceneManager.LoadScene(1);
    }
    public void ToWin()
    {
        SceneManager.LoadScene(5);
    }
    public void ToGameOver()
    {
        SceneManager.LoadScene(6);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
