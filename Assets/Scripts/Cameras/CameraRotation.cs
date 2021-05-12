using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [Header("Referencias")]
    public Transform target;

    private void Update()
    {
        transform.LookAt(target);
    }
}
