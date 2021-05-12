using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{
    public MenuButtonController menuButtonController;
    public GameObject menu;
    public GameObject levelSelect;

    private void Update()
    {
        if (menu.activeInHierarchy == true && levelSelect.activeInHierarchy == false)
        {
            if (menuButtonController.index == 0)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    StartCoroutine(LevelSelect());
                }
            }
            else if (menuButtonController.index == 1)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    QuitGame();
                }
            }
        }
        else if(menu.activeInHierarchy == false && levelSelect.activeInHierarchy == true)
        {
            if (menuButtonController.index == 0)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level01");
                }
            }
            else if (menuButtonController.index == 1)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level02");
                }
            }
            else if (menuButtonController.index == 2)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level03");
                }
            }
            else if (menuButtonController.index == 3)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level04");
                }
            }
            else if (menuButtonController.index == 4)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level05");
                }
            }
            else if (menuButtonController.index == 5)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level06");
                }
            }
            else if (menuButtonController.index == 6)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level07");
                }
            }
            else if (menuButtonController.index == 7)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level08");
                }
            }
            else if (menuButtonController.index == 8)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level09");
                }
            }
            else if (menuButtonController.index == 9)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level10");
                }
            }
            else if (menuButtonController.index == 10)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level11");
                }
            }
            else if (menuButtonController.index == 11)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level12");
                }
            }
            else if (menuButtonController.index == 12)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level13");
                }
            }
            else if (menuButtonController.index == 13)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level14");
                }
            }
            else if (menuButtonController.index == 14)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level15");
                }
            }
            else if (menuButtonController.index == 15)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level16");
                }
            }
            else if (menuButtonController.index == 16)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level17");
                }
            }
            else if (menuButtonController.index == 17)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level18");
                }
            }
            else if (menuButtonController.index == 18)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Level19");
                }
            }
            else if (menuButtonController.index == 19)
            {
                if (Input.GetAxis("Submit") != 0 || Input.GetButton("Submit2"))
                {
                    PlayGame("Leve20");
                }
            }
        }
    }

    IEnumerator LevelSelect()
    {
        menu.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        menuButtonController.axis = "Horizontal";
        menuButtonController.maxIndex = 19;
        levelSelect.SetActive(true);
    }

    public void PlayGame(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
