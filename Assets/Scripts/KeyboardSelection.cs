using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardSelection : MonoBehaviour
{
    [SerializeField] Button keyboardSelectionDefaultPosition;

    void Start()
    {
        SetDefaultButton();
    }

    void Update()
    {
        
    }

    public void SetDefaultButton()
    {
        keyboardSelectionDefaultPosition.Select();
    }
}
