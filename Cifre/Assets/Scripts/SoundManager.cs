using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip down, kill;
    static AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        down = Resources.Load<AudioClip>("PutDown");
        kill = Resources.Load<AudioClip>("kill");
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "down":
                audioSource.PlayOneShot(down);
                break;
            case "kill":
                audioSource.PlayOneShot(kill);
                break;
        }
    }
}


