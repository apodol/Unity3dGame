using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDoor : MonoBehaviour



{
    public GameObject but;

    public GameObject UIscore;
    public GameObject score;
    public GameObject soundClap;
    public AudioSource audio;
    public GameObject newtittleText;




    public AudioSource audioaudior;
    public GameObject panel;
    // Start is called before the first frame update
    string se;
    string ss;
    int sx;
    void Start()
    {

        newtittleText.GetComponent<Text>().text = "";
        se = PlayerPrefs.GetString("tittle");

        panel.SetActive(false);
        

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playSoundEffect()
    {
        audioaudior.Play();
    }

    void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Obstacle")
        {
            playSoundEffect();
            panel.SetActive(true);
            


                ss = soundClap.GetComponent<Text>().text;
            if (se != ss) {
                newtittleText.GetComponent<Text>().text = "New Tittle Aquired";
                audio.Play();
                
            }

            if (other.name.Contains("RevPush"))
            {
                GameObject gm = other.transform.GetChild(4).gameObject;
                Destroy(gm);

            }
            else if (other.name.Contains("RevPull"))
            {
                GameObject gm = other.transform.GetChild(4).gameObject;
                Destroy(gm);

            }




            
            Time.timeScale = 0;

            GameObject gem = other.transform.GetChild(0).gameObject;
            Destroy(gem);

            GameObject ee = other.transform.GetChild(2).gameObject;
            Destroy(ee);

            UIscore.GetComponent<Text>().text =score.GetComponent<Text>().text;
            sx = int.Parse(score.GetComponent<Text>().text);
            PlayerPrefs.SetInt("currentScore",sx);
            score.GetComponent<Text>().text = "";
            






        }
        
    }
}
