using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float CameraOffset = -10f;

    void LateUpdate()
    {
        Vector3 targetPossition = target.transform.position;
        transform.position = new Vector3(targetPossition.x, targetPossition.y, CameraOffset);
    }
}
