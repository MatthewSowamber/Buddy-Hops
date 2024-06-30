using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public enum SoundFXCat {Carrot, Enemy}
    public GameObject audioObject;
    public AudioClip[] carrot;
    public AudioClip[] enemy;

    public void AudioTrigger(SoundFXCat audioType, Vector3 audioPosition, float volume)
    {
        GameObject newAudio = GameObject.Instantiate(audioObject, audioPosition, Quaternion.identity);
        ControlAudio ca = newAudio.AddComponent<ControlAudio>();
        switch(audioType)
        {
            case (SoundFXCat.Carrot):
                ca.myClip = carrot[Random.Range(0, carrot.Length)]; 
                break;
            case (SoundFXCat.Enemy):
                ca.myClip = enemy[Random.Range(0, enemy.Length)];
                break;
        }

        ca.volume = volume;
        ca.StartAudio();
    }
}
