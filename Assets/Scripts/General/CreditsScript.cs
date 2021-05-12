using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    public MenuButtonController menuButtonController;

    private void Update()
    {
        if (menuButtonController.index == 0)
        {
            if (Input.GetAxis("Submit") != 0)
            {
                MenuGame();
            }
        }
    }

    private void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
