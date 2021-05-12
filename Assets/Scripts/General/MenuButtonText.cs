using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonText : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    [SerializeField] int thisIndex;
    public Text text;

    private void Update()
    {
        if (menuButtonController.index == thisIndex)
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }
    }
}
