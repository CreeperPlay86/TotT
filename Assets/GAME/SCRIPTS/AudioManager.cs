using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource a; 

    public string name;
 
    void Start() 
    { 
        a.clip = Microphone.Start(name, true, 20, 4000);  
        StartCoroutine(A());    
    } 
 
    IEnumerator A() 
    { 
        yield return new WaitForSeconds(5f); 
        a.volume = 3f; 
        Microphone.End(name); //Stop the audio recording     
        a.Play(); //Playback the recorded audio    
        Debug.Log("начало воспроизведения записи");  
    } 
 
    void Update() 
    { 
        if(Input.GetKeyDown(KeyCode.E)){ 
            a.Play();       
        } 
    }
}
