using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static float GeneralSpeedAspect = 1;

    [SerializeField] private float _runningSpeed;

    private void Start()
    {
        GeneralSpeedAspect = 1;
    }

    private void Update()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + _runningSpeed * GeneralSpeedAspect * Time.deltaTime);
        transform.position = newPos;
    }

    public void SetRunningSpeed(float newRunningSpeed)
    {
        _runningSpeed = newRunningSpeed;
    }
}
