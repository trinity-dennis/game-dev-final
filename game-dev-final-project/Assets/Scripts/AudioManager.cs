using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public AudioClip collectSound;
    public AudioClip backgroundMusic;
    [SerializeField] AudioMixer audioMixer; 
    private AudioSource audioSource;

    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AudioManager>();

                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("AudioManager");
                    instance = singletonObject.AddComponent<AudioManager>();
                }
            }

            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeAudio();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void InitializeAudio()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

        // Set the AudioMixer for the AudioSource
        if (audioMixer != null)
        {
            audioSource.outputAudioMixerGroup = audioMixer.FindMatchingGroups("Master")[0];
        }

        // Play background music on start
        PlayBackgroundMusic();
    }

    public void PlayCollectSound(float volumeScale = 1.0f)
{
    if (collectSound != null)
    {
        audioSource.PlayOneShot(collectSound, volumeScale);
    }
}

    public void PlayBackgroundMusic()
    {
        if (backgroundMusic != null)
        {
            audioSource.clip = backgroundMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
