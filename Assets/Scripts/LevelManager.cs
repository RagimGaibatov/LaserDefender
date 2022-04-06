using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float sceneLoadDelay = 1f;

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void loadGameOver()
    {
        StartCoroutine(WaitAndLoad("Game Over menu", sceneLoadDelay));
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }

    IEnumerator WaitAndLoad(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}