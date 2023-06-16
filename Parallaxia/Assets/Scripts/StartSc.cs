using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSc : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    public void EndGame()
    {
        Application.Quit();
        
    }
    public void EndScene()
    {
        SceneManager.LoadScene(3);
    }
    public void ReplayLevels()
    {
        SceneManager.LoadScene(4);
    }
}
