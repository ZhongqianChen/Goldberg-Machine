using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Add this Script Directly to The Death Zone
public class PlaySound : MonoBehaviour
{
    public AudioClip t_Audio;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = t_Audio;
    }

    void OnCollisionEnter2D()  //Plays Sound Whenever collision detected
    {
        GetComponent<AudioSource>().Play();
    }
}
