using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getHhighscore : MonoBehaviour
{
    int highscore;
    string titlos;
    public GameObject txt;

    void Start()
    {

        if (!PlayerPrefs.HasKey("highscore"))
        {
            txt.GetComponent<Text>().text = "Brainless";
            gameObject.GetComponent<Text>().text = "0";        }
        else
        {
            highscore = PlayerPrefs.GetInt("highscore");
            titlos = PlayerPrefs.GetString("tittle");

            txt.GetComponent<Text>().text = titlos;
            gameObject.GetComponent<Text>().text = highscore.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerPrefs.HasKey("highscore"))
        {
            txt.GetComponent<Text>().text = "Tittleless";
            gameObject.GetComponent<Text>().text = "0";
        }
        else
        {
            highscore = PlayerPrefs.GetInt("highscore");
            titlos = PlayerPrefs.GetString("tittle");

            txt.GetComponent<Text>().text = titlos;
            gameObject.GetComponent<Text>().text = highscore.ToString();
        }
    }
}
