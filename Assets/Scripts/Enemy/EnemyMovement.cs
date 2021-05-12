using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Referencias")]
    public Transform target;

    [Header("Configuracion")]
    public float speedPos;
    public float speedRot;
    public float timeWait;

    [Header("Posiciones")]
    public Vector3 firstPos;
    public Vector3 lastPos;

    [Header("Rotacion")]
    public Transform firstRot;
    public Transform lastRot;

    private void Update()
    {
        float step = speedPos * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (transform.position == lastPos)
        {
            StartCoroutine(Wait(firstRot, lastRot, firstPos));
        }
        else if (transform.position == firstPos)
        {
            StartCoroutine(Wait(lastRot, firstRot, lastPos));
        }
    }

    IEnumerator Wait(Transform rot1, Transform rot2, Vector3 pos)
    {
        yield return new WaitForSeconds(timeWait);
        transform.rotation = Quaternion.Slerp(rot1.rotation, rot2.rotation, speedRot);
        target.position = pos;
    }
}
