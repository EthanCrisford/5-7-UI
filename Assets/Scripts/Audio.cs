using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider sfxSlider;
    [System.Serializable]

    public class Sound
    {
        public string name;

        public AudioClip clip;
        public AudioClip OnClickSFX;

        [Range(0f, 1f)]
        public float volume;
        [Range(1f, 3f)]
        public float pitch;

        [HideInInspector]
        public AudioSource source;
    }

    public AudioSource audioSource;
    public AudioClip clip;
    public AudioClip OnClickSFX;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVol"))
        {
            PlayerPrefs.SetFloat("musicVol", 1);
        }

        if (!PlayerPrefs.HasKey("sfxVol"))
        {
            PlayerPrefs.SetFloat("sfxVol", 1);
        }

        Load();

        audioSource = GetComponent<AudioSource>();

        AudioClip OnClickSFX = GetComponent<AudioClip>();
    }


    public void Update()
    {
        Save();
    }

    public void ChangeVol()
    {
        AudioListener.volume = volumeSlider.value;
        
    }

    public void ChangeSFXVol()
    {

        audioSource.PlayOneShot(clip, sfxSlider.value);
        audioSource.PlayOneShot(OnClickSFX, sfxSlider.value);

    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVol", volumeSlider.value);
        PlayerPrefs.SetFloat("sfxVol", sfxSlider.value);
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVol");
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVol");
    }

    public void PlayOnClickSFX()
    {
        audioSource.PlayOneShot(OnClickSFX);
    }
}

