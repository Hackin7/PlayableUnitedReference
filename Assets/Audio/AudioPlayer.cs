using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    //https://docs.unity3d.com/Manual/class-AudioSource.html
    //https://docs.unity3d.com/ScriptReference/AudioSource.html
    public AudioClip sound;
    public AudioClip music;
    private AudioSource audio;
    //music used from https://files.freemusicarchive.org/storage-freemusicarchive-org/music/blocSonic/DJ_Spooky/Of_Water_and_Ice/DJ_Spooky_-_09_-_Arctic_Rhythms_Dubstep_Mix.mp3

    public Text visualisation;
    
    // Start is called before the first frame update
    void Start()
    {
        //as = gameObject.AddComponent<AudioSource>();
        audio = GetComponent<AudioSource>();
        audio.clip = music;
        audio.volume = 1.0f; //Range 0.0f to 1.0f
        audio.pitch = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(sound, 1.0f); //sound, volume
        }
        if (Input.GetKeyDown(KeyCode.Space)){ audio.Play(); }
        if (Input.GetKeyDown(KeyCode.P)){ audio.Pause(); }
        if (Input.GetKeyDown(KeyCode.S)){ audio.Stop(); }
        if (Input.GetKeyDown(KeyCode.L)) { audio.loop = ! audio.loop; }

        if (Input.GetKeyDown(KeyCode.Q)) { audio.pitch += 1.0f; }
        if (Input.GetKeyDown(KeyCode.A)) { audio.pitch -= 1.0f; }

        audio.mute = Input.GetKey(KeyCode.M);

        visualisation.text =
            "audio.pitch = " + audio.pitch + "\n\n" +
            "audio.time = " + audio.time + "\n" +
            "audio.timeSamples = " + audio.timeSamples + "\n" +
            "audio.isPlaying = " + audio.isPlaying + "\n";
    }
}
