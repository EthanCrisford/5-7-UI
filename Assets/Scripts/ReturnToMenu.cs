using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("FrontEnd UI Menu");
        }
    }

    public void EscToMenu()
    {
        Input.GetKeyDown(KeyCode.Escape);
    }
}
