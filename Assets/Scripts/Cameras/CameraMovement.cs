using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Referencias")]
    public Transform target;

    [Header("Configuracion")]
    public float speed;
    public float timeWait;
    public Vector3 firstPos;
    public Vector3 lastPos;

    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        
        if(transform.position == lastPos)
        {
            StartCoroutine(Wait(firstPos));
        }
        else if(transform.position == firstPos)
        {
            StartCoroutine(Wait(lastPos));
        }
    }

    IEnumerator Wait(Vector3 pos)
    {
        yield return new WaitForSeconds(timeWait);
        target.position = pos;
    }
}
