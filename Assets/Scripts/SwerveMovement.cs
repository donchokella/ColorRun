using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    private SwerveInputSystem _swerveInputSystem;
    [SerializeField] private float _swerveSpeed = 0.5f;
    [SerializeField] private float _maxSwerveAmount = 1f;
    [SerializeField] private float _limitX;


    private void Awake()
    {
        _swerveInputSystem = GetComponent<SwerveInputSystem>();
    }

    private void Update()
    {
        float swerveAmount = Time.deltaTime * _swerveSpeed * _swerveInputSystem.MoveFactorX;
        swerveAmount = Mathf.Clamp(swerveAmount, -_maxSwerveAmount, _maxSwerveAmount);

        Vector3 newPosition = transform.position + new Vector3(swerveAmount, 0, 0);

        newPosition.x = Mathf.Clamp(newPosition.x, -_limitX, _limitX);
        transform.position = newPosition;
    }
}
