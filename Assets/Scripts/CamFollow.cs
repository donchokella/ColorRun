using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform cameraTargetToFollow;

    public float smoothSpeed;
    public Vector3 offSet;

    private void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offSet + cameraTargetToFollow.position, smoothSpeed);
        transform.position = newPos;
    }
}
