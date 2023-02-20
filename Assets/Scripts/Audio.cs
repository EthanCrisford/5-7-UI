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

        [Range(0f, 1f)]
        public float volume;
        [Range(1f, 3f)]
        public float pitch;

        [HideInInspector]
        public AudioSource source;
    }

    public AudioSource audioSource;
    public AudioClip clip;

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
    }

    public void Update()
    {
        Save();
    }

    void Awake()
    {
//AudioListener.volume = volumeSlider.value;
        
        //DontDestroyOnLoad(this.gameObject);
    }

    public void ChangeVol()
    {
        AudioListener.volume = volumeSlider.value;
        
    }

    public void ChangeSFXVol()
    {
        //AudioListener.volume = volumeSlider.value;

        audioSource.PlayOneShot(clip, sfxSlider.value);

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

        print("sfx vol=" + PlayerPrefs.GetFloat("sfxVol"));
    }

}

