using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreText : MonoBehaviour
{

    public GameObject txt;

    int highscore;
    string titlos="";

    void Start()
    {

        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetInt("highscore", 0);
            titlos = "Brainless";
            txt.GetComponent<Text>().text = titlos;
            PlayerPrefs.SetString("tittle", titlos);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetInt("highscore", 0);
        }
        int highscore=PlayerPrefs.GetInt("highscore");
        

        if (highscore <= 5) {
            titlos = "Brainless";
            
        }
        else if (highscore>5 && highscore<=10) {
            titlos = "Moron";
           
        }
        else if (highscore > 10 && highscore <= 20) {
            titlos = "Dumb";
          
        }
        else if(highscore > 20 && highscore <=30) {
            titlos = "Witless";
        }
        else if (highscore > 30 && highscore <= 50)
        {
            titlos = "Average";
        }
        else if (highscore > 50 && highscore <= 70)
        {
            titlos = "Brainiac";
        }
        else if (highscore > 70 && highscore <= 90)
        {
            titlos = "Genius";
        }
        else if (highscore > 90 && highscore <= 110)
        {
            titlos = "Prodigy";
        }
        else if (highscore > 110 && highscore <= 130)
        {
            titlos = "Mastermind";
        }
        else if (highscore > 130 && highscore <= 150)
        {
            titlos = "Ascended";
        }
        else if (highscore > 150 && highscore <= 200)
        {
            titlos = "GOD";
        }
        else if (highscore > 200 && highscore <= 500)
        {
            titlos = "GODKILLER";
        }
        else if (highscore > 500)
        {
            titlos = "GODEATER";
        }
       



        PlayerPrefs.SetString("tittle", titlos);
        txt.GetComponent<Text>().text = titlos;



    }
}
