using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    [SerializeField] int thisIndex;
    public Image image;

    private void Update()
    {
        if (menuButtonController.index == thisIndex)
        {
            image.enabled = true;
        }
        else
        {
            image.enabled = false;
        }
    }
}
