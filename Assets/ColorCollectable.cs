using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCollectable : MonoBehaviour, IInteractable
{
    public Colors MyColor;

    public float ScaleIncreaseAmount => _scaleIncreaseAmount;
    [SerializeField] private float _scaleIncreaseAmount = 1;
}
