using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCanvasScript : MonoBehaviour
{
    [Header("Referencias")]
    public PlayerController playerController;
    public GameObject gameOverObject;
    public GameObject winObject;
    public GameObject xRayObject;
    public MenuButtonController menuButtonController;

    private void Update()
    {
        if(playerController.isGameOver == true)
        {
            xRayObject.SetActive(false);
            gameOverObject.SetActive(true);
        }
        else if(playerController.win == true)
        {
            xRayObject.SetActive(false);
            winObject.SetActive(true);
        }
        else if(playerController.XRayActive == true)
        {
            xRayObject.SetActive(true);
        }
        else if (playerController.XRayActive == false)
        {
            xRayObject.SetActive(false);
        }

        if (playerController.isGameOver == true || playerController.win == true)
        {
            if (menuButtonController.index == 0)
            {
                if (Input.GetAxis("Submit") != 0)
                {
                    Level();
                }
            }
            else if (menuButtonController.index == 1)
            {
                if (Input.GetAxis("Submit") != 0)
                {
                    MainMenuGame();
                }
            }
        }
    }

    public void MainMenuGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Level()
    {
        if(playerController.win == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(playerController.isGameOver == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Credits()
    {
        //ESTO FALTA POR HACER EN LA DEMO SOLO VOY A USAR NEXTLEVEL() POR EL INDEX
    }
}
