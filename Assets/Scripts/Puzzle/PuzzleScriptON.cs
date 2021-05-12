using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScriptON : MonoBehaviour
{
    [Header("Referencias")]
    public Transform cameraMainObject;
    public Transform player;
    public GameObject cameraTarget;
    public GameObject cameraHitBox;
    public CameraController cameraController;
    public GameObject puzzleOn;
    public GameObject puzzleOff;

    [Header("Configuracion")]
    public Vector3 newCameraOffset;

    private void Awake()
    {
        puzzleOn.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(cameraAnim());
        }
    }

    IEnumerator cameraAnim()
    {
        if (cameraHitBox.activeInHierarchy == false)
        {
            puzzleOn.SetActive(true);
            puzzleOff.SetActive(false);

            cameraController.target = cameraMainObject;
            cameraController.offset = newCameraOffset;
            yield return new WaitForSeconds(1.3f);

            cameraHitBox.SetActive(true);
            cameraTarget.SetActive(true);
            yield return new WaitForSeconds(1f);

            cameraController.target = player;
            cameraController.offset = cameraController.playerOffset;

            puzzleOn.SetActive(false);
            puzzleOff.SetActive(true);
        }
    }
}
