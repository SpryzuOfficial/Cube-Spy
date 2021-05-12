using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleLaserScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private bool isGameOver = false;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isGameOver = true;
            meshRenderer.enabled = true;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (isGameOver == false)
        {
            if (other.tag == "XRayOn")
            {
                meshRenderer.enabled = true;
            }
            else if (other.tag == "XRayOff")
            {
                meshRenderer.enabled = false;
            }
        }
    }
}
