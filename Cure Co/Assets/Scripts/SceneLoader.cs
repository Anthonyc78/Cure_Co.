using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

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
    public void ToGameOver()
    {
        //SceneManager.LoadScene("LossScreen");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
