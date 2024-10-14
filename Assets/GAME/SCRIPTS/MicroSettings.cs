using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class MicroSettings : MonoBehaviour
{
    //void Start()
    //{
    //    CheckMicrophoneAccess();
    //}
//
    //void CheckMicrophoneAccess()
    //{
    //    if (Microphone.devices.Length > 0)
    //    {
    //        Debug.Log("Microphone is available.");
    //        StartRecording();
    //    }
    //    else
    //    {
    //        Debug.Log("No microphone found.");
    //    }
    //}
//
    //void StartRecording()
    //{
    //    string micName = Microphone.devices[0];
    //    int sampleRate = 44100;
    //    AudioClip recordedClip = Microphone.Start(micName, true, 10, sampleRate);
    //    
    //    Debug.Log("Recording started: " + micName);
    //}
//
    //void OnDisable()
    //{
    //    Microphone.End(Microphone.devices[0]);
    //    Debug.Log("Recording stopped.");
    //}

    //// ПОЛУЧЕНИЕ АУДИО - РАЗБОР ТЕКСТА БАЗОВЫХ СЛОВ - ВЫДАЧА АУДИО ИСКУСТВЕННЫМ ИНТЕЛЕКТОМ
    //public string device;
    //void Start() 
    //{
    //    //foreach (string device in Microphone.devices) 
    //    //{
    //    //    Debug.Log("Name: " + device);
    //    //}
    //}

    public AudioSource  a;

    public Microphone micro;

    //public Audio.AudioMixerGroup Mixer;

    public AudioMixer audioMixer;

    public float startDB;

    public string name;

    void Start()
    {
        a.clip = Microphone.Start(null, true, 20, 4000); 
        StartCoroutine(A());   

        #region CHECK
            if (Microphone.devices.Length > 0)
            {
                Debug.Log("Microphone is available.");
                
            }
            else
            {
                Debug.Log("No microphone found.");
            }

            foreach (string device in Microphone.devices) 
            {
                Debug.Log("Name: " + device);
            }
        #endregion
    }

    IEnumerator A()
    {
        yield return new WaitForSeconds(5f);
        Microphone.End(null); //Stop the audio recording    

        a.Play(); //Playback the recorded audio   
        Debug.Log("начало воспроизведения записи"); 

        audioMixer.GetFloat(name, out startDB);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            a.Play();      
        }
        audioMixer.GetFloat(name, out startDB);
    }

//AudioSource audioSource;
//
//    void Start()
//    {
//        audioSource = GetComponent<AudioSource>();
//    }
//
//    // Получение данных о громкости микрофона
//    float GetMicrophoneVolume()
//    {
//        return (float)Math.Pow(10, (audioSource.GetMicrophoneVolume() / 20));
//    }
//
//    void Update()
//    {
//        float d = GetMicrophoneVolume();
//        Debug.Log("Громкость микрофона: " + d);
//    }
}
