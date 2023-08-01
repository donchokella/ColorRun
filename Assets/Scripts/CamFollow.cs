using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Transform _cameraTargetToFollow;
    [SerializeField] private float _smoothSpeed;
    [SerializeField] private Vector3 _offSet;
    [SerializeField] private Transform _lookTarget;

    private void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, _offSet + _cameraTargetToFollow.position, _smoothSpeed * Time.deltaTime);
        transform.position = newPos;
        transform.LookAt(_lookTarget);
    }
}
