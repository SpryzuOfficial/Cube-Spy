using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInvisibleScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public MeshRenderer childMeshRenderer;

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
            childMeshRenderer.enabled = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (isGameOver == false)
        {
            if (other.tag == "XRayOn")
            {
                meshRenderer.enabled = true;
                childMeshRenderer.enabled = true;
            }
            else if (other.tag == "XRayOff")
            {
                meshRenderer.enabled = false;
                childMeshRenderer.enabled = false;
            }
        }
    }
}
