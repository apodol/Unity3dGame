using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scores : MonoBehaviour
{
    public GameObject text0;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    public GameObject text9;
    public GameObject text10;
    public GameObject text11;
    public GameObject text12;



    string titol;
    int highscore;
    void Start()
    {
        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetInt("highscore", 0);
            PlayerPrefs.SetString("tittle", "Brainless");

        }
    }

    // Update is called once per frame
    void Update()
    {

        highscore = PlayerPrefs.GetInt("highscore");

        if (highscore <= 5)
        {
            
            text0.GetComponent<Text>().text = "Brainless";

        }
        else if (highscore > 5 && highscore <= 10)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";

        }
        else if (highscore > 10 && highscore <= 20)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            

        }
        else if (highscore > 20 && highscore <= 30)
        {
            
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
        }
        else if (highscore > 30 && highscore <= 50)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
            text4.GetComponent<Text>().text = "Average";
        }
        else if (highscore > 50 && highscore <= 70)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
            text4.GetComponent<Text>().text = "Average";
            text5.GetComponent<Text>().text = "Brainiac";
        }
        else if (highscore > 70 && highscore <= 90)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
            text4.GetComponent<Text>().text = "Average";
            text5.GetComponent<Text>().text = "Brainiac";
            text6.GetComponent<Text>().text = "Genius";
        }
        else if (highscore > 90 && highscore <= 110)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
            text4.GetComponent<Text>().text = "Average";
            text5.GetComponent<Text>().text = "Brainiac";
            text6.GetComponent<Text>().text = "Genius";
            text7.GetComponent<Text>().text = "Prodigy";
        }
        else if (highscore > 110 && highscore <= 130)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
            text4.GetComponent<Text>().text = "Average";
            text5.GetComponent<Text>().text = "Brainiac";
            text6.GetComponent<Text>().text = "Genius";
            text7.GetComponent<Text>().text = "Prodigy";
            text8.GetComponent<Text>().text = "Mastermind";
        }
        else if (highscore > 130 && highscore <= 150)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
            text4.GetComponent<Text>().text = "Average";
            text5.GetComponent<Text>().text = "Brainiac";
            text6.GetComponent<Text>().text = "Genius";
            text7.GetComponent<Text>().text = "Prodigy";
            text8.GetComponent<Text>().text = "Mastermind";
            text9.GetComponent<Text>().text = "Ascened";
        }
        else if (highscore > 150 && highscore <= 200)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
            text4.GetComponent<Text>().text = "Average";
            text5.GetComponent<Text>().text = "Brainiac";
            text6.GetComponent<Text>().text = "Genius";
            text7.GetComponent<Text>().text = "Prodigy";
            text8.GetComponent<Text>().text = "Mastermind";
            text9.GetComponent<Text>().text = "Ascened";
            text10.GetComponent<Text>().text = "GOD";
        }
        else if (highscore > 200 && highscore <= 500)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
            text4.GetComponent<Text>().text = "Average";
            text5.GetComponent<Text>().text = "Brainiac";
            text6.GetComponent<Text>().text = "Genius";
            text7.GetComponent<Text>().text = "Prodigy";
            text8.GetComponent<Text>().text = "Mastermind";
            text9.GetComponent<Text>().text = "Ascened";
            text10.GetComponent<Text>().text = "GOD";
            text11.GetComponent<Text>().text = "GODKILLER";

        }
        else if (highscore > 500)
        {
            text0.GetComponent<Text>().text = "Brainless";
            text1.GetComponent<Text>().text = "Moron";
            text2.GetComponent<Text>().text = "Dumb";
            text3.GetComponent<Text>().text = "Witless";
            text4.GetComponent<Text>().text = "Average";
            text5.GetComponent<Text>().text = "Brainiac";
            text6.GetComponent<Text>().text = "Genius";
            text7.GetComponent<Text>().text = "Prodigy";
            text8.GetComponent<Text>().text = "Mastermind";
            text9.GetComponent<Text>().text = "Ascened";
            text10.GetComponent<Text>().text = "GOD";
            text11.GetComponent<Text>().text = "GODKILLER";
            text12.GetComponent<Text>().text = "GODEATER";
        }

    }
    public void backee() {
        SceneManager.LoadScene(0);
    }
}
