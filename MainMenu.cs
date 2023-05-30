using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f; // This will resume the game
    }

    public void ExitGame() {
        PlayerPrefs.DeleteAll();
        Debug.Log("Quit");  
        Application.Quit();
    }

    public void ChangeToMenu() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }   

}

