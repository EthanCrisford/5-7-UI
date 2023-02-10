using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardSelection : MonoBehaviour
{
    [SerializeField] Button keyboardSelectionDefualtPosition;

    void Start()
    {
        keyboardSelectionDefualtPosition.Select();
    }

    void Update()
    {
        
    }
}
