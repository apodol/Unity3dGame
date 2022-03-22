using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    // Start is called before the first frame update
    public void replayLevel() 
    {
        PlayerPrefs.SetInt("currentScore", 0);
        PlayerPrefs.SetString("sceneNumber", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(0);


    }
    public void quitGame() {
        PlayerPrefs.SetInt("currentScore", 0);
        Application.Quit();
    }
}
