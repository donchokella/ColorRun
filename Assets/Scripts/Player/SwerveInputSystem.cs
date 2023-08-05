using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInputSystem : MonoBehaviour
{
    private float _lastFrameMousePositionX;
    private float _moveFacetorX;

    public float MoveFactorX => _moveFacetorX;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastFrameMousePositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            _moveFacetorX = Input.mousePosition.x - _lastFrameMousePositionX;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _moveFacetorX = 0f;
        }
    }
}
