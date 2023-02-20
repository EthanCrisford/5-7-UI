using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
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

    void Start()
    {
        {
            if (!PlayerPrefs.HasKey("musicVol"))
            {
                PlayerPrefs.SetFloat("musicVol", 1);
                Load();
            }
            else
            {
                Load();
            }
        }
    }

    void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
            AudioListener.volume = volumeSlider.value;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void ChangeVol()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVol", volumeSlider.value);
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVol");
    }
}

