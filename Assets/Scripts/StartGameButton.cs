using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
       
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
