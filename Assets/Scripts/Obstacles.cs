using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;



public class Obstacles : MonoBehaviour
{
    public GameObject myPrefabPull;
    public GameObject myPrefabPush;
    public GameObject myPrefabPullR;
    public GameObject myPrefabPushR;
    public GameObject player;
    public GameObject score;
    public AudioSource locked;


    
    public AudioSource au;

    List<GameObject> allDoors = new List<GameObject>();

    double startPoss = 1;
    double endPoss = 1;
    int pulling = -1;
    int open = 0;
    int gameScore;
    int megaliteroScore;
    int highscore;
    int freeze = 0;
    string lastScene;

    void Start()
    {



        if (!PlayerPrefs.HasKey("sceneNumber"))
        {
            gameScore = 0;
        }
        else {
            lastScene = PlayerPrefs.GetString("sceneNumber");
            if (lastScene == "Main menu")
            {
                gameScore = 0;
            }

            if (lastScene == "SampleScene")
            {
                Debug.Log("yooooooooooman");
                gameScore = PlayerPrefs.GetInt("currentScore");
                score.GetComponent<Text>().text = gameScore.ToString();


            }
        }

        




        int random = Random.Range(1, 5);

        if (random == 1)
        {
            allDoors.Add(Instantiate(myPrefabPull, new Vector3(myPrefabPush.transform.position.x, myPrefabPull.transform.position.y, player.transform.position.z + 30), Quaternion.Euler(new Vector3(0, 90, 0))));

        }
        else if (random == 2)
        {
            allDoors.Add(Instantiate(myPrefabPush, new Vector3(myPrefabPush.transform.position.x, myPrefabPush.transform.position.y, player.transform.position.z + 30), Quaternion.Euler(new Vector3(0, 90, 0))));
        }
        else if (random == 3)
        {
            allDoors.Add(Instantiate(myPrefabPullR, new Vector3(myPrefabPush.transform.position.x, myPrefabPush.transform.position.y, player.transform.position.z + 30), Quaternion.Euler(new Vector3(0, 90, 0))));
        }
        else if (random == 4)
        {
            allDoors.Add(Instantiate(myPrefabPushR, new Vector3(myPrefabPush.transform.position.x, myPrefabPush.transform.position.y, player.transform.position.z + 30), Quaternion.Euler(new Vector3(0, 90, 0))));
        }

        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetInt("highscore", 1);
        }


    }
    public void freeze0() {
        freeze = 0;
        open=1;
    }
    // Update is called once per frame
    void Update()
    {



        if (Time.timeScale == 0)
        {
            freeze = 1;
        }

        if (Input.GetMouseButtonDown(0))
        {
            startPoss = Input.mousePosition.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            endPoss = Input.mousePosition.y;
            
            if (endPoss < startPoss)
            {
                pulling = 1;
                
            }
            else if (endPoss > startPoss)
            {
                pulling = 0;
               
            }

            



            
             if (allDoors[0].name.Contains("RevPush") && pulling == 1)
            {
                open = 1;
                
            }
            else if (allDoors[0].name.Contains("RevPull") && pulling == 0)
            {
                open = 1;
                
            }
            else if (allDoors[0].name.Contains("PushDoor") && pulling == 0)
            {
               
                open = 1;

            }
            else if (allDoors[0].name.Contains("PullDoor") && pulling == 1)
            {
                open = 1;
               
            }


            if (allDoors[0].name.Contains("RevPush") && pulling == 0)
            {
                open = 2;

            }
            else if (allDoors[0].name.Contains("RevPull") && pulling == 1)
            {
                open = 2;

            }
            else if (allDoors[0].name.Contains("PushDoor") && pulling == 1)
            {

                open = 2;

            }
            else if (allDoors[0].name.Contains("PullDoor") && pulling == 0)
            {
                open = 2;

            }





            if (freeze == 0)
            {
                if (open == 1)
                {


                    gameScore = gameScore + 1;


                    highscore = PlayerPrefs.GetInt("highscore");
                    Debug.Log(highscore);


                    if (highscore <= gameScore)
                    {

                        highscore = gameScore;


                        PlayerPrefs.SetInt("highscore", highscore);

                        PlayerPrefs.Save();




                    }


                    score.GetComponent<Text>().text = gameScore.ToString();
                    au.Play();
                    GameObject child = allDoors[0].transform.GetChild(0).gameObject;


                    if (allDoors[0].name.Contains("RevPush"))
                    {
                        child.transform.rotation = Quaternion.Euler(new Vector3(-90, 180, 0));

                    }
                    else if (allDoors[0].name.Contains("RevPull"))
                    {
                        child.transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 0));

                    }
                    else if (allDoors[0].name.Contains("PushDoor"))
                    {

                        child.transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 0));

                    }
                    else if (allDoors[0].name.Contains("PullDoor"))
                    {
                        child.transform.rotation = Quaternion.Euler(new Vector3(-90, 180, 0));

                    }
















                    Destroy(allDoors[0].GetComponent<BoxCollider>());
                    GameObject text = allDoors[0].transform.GetChild(2).gameObject;
                    Destroy(text);


                    if (allDoors[0].name.Contains("RevPush") && pulling == 1)
                    {
                        GameObject gm = allDoors[0].transform.GetChild(4).gameObject;
                        Destroy(gm);

                    }
                    else if (allDoors[0].name.Contains("RevPull") && pulling == 0)
                    {
                        GameObject gm = allDoors[0].transform.GetChild(4).gameObject;
                        Destroy(gm);

                    }



                    int ran = Random.Range(1, 5);

                    if (ran == 1)
                    {
                        allDoors.Add(Instantiate(myPrefabPull, new Vector3(allDoors[0].transform.position.x, allDoors[0].transform.position.y, allDoors[0].transform.position.z + 10), Quaternion.Euler(new Vector3(0, 90, 0))));

                    }
                    else if (ran == 2)
                    {
                        allDoors.Add(Instantiate(myPrefabPush, new Vector3(allDoors[0].transform.position.x, allDoors[0].transform.position.y, allDoors[0].transform.position.z + 10), Quaternion.Euler(new Vector3(0, 90, 0))));
                    }
                    else if (ran == 3)
                    {
                        allDoors.Add(Instantiate(myPrefabPushR, new Vector3(allDoors[0].transform.position.x, allDoors[0].transform.position.y, allDoors[0].transform.position.z + 10), Quaternion.Euler(new Vector3(0, 90, 0))));
                    }
                    else if (ran == 4)
                    {
                        allDoors.Add(Instantiate(myPrefabPullR, new Vector3(allDoors[0].transform.position.x, allDoors[0].transform.position.y, allDoors[0].transform.position.z + 10), Quaternion.Euler(new Vector3(0, 90, 0))));
                    }

                    if (Time.timeScale == 0)
                    {
                        freeze = 1;
                    }
                    else {
                        Destroy(allDoors[0], 20);
                    }



                    allDoors.Remove(allDoors[0]);





                }
                else if (open == 2)
                {
                    freeze = 1;
                    locked.Play();
                    


                }
            }



        }

        pulling = -1;
        open = 0;

    }
}
