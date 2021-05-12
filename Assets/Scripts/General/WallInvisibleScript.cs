using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallInvisibleScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "XRayOn")
        {
            meshRenderer.enabled = false;
        }
        else if (other.tag == "XRayOff")
        {
            meshRenderer.enabled = true;
        }
    }
}
