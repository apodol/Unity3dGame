using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerReward : MonoBehaviour



{
    public AudioSource audioaudiore;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playSoundEffect() 
    {
        audioaudiore.Play();
    }

    void OnTriggerEnter(Collider other)
    {
        
        playSoundEffect();
    }
}