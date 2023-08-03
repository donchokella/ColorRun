using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _runningSpeed;
    private PlayerColor _currentColor = PlayerColor.Blue; // Default Player Color

    public enum PlayerColor
    {
        Blue,
        Purple,
        Orange
    }

    
    private void Update()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + _runningSpeed * Time.deltaTime);
        transform.position = newPos;
    }

    public void SetRunningSpeed(float newRunningSpeed)
    {
        _runningSpeed = newRunningSpeed;
    }

}
