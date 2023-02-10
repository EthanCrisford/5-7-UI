using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    [SerializeField] Button startButton;

    void Start()
    {
        startButton.Select();
    }

    void Update()
    {
       
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
