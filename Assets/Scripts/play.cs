using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeScene() {
        PlayerPrefs.SetString("sceneNumber", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(1);
    }
    public void changeScene1()
    {

        SceneManager.LoadScene(2);

    }

}
