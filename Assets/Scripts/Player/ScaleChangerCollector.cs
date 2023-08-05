using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScaleChangerCollector : MonoBehaviour
{
    private InteractManager _interactManager;
    //private float scaleIncrement = 1.05f;

    [SerializeField] private Transform playerTransform;

    private void Start()
    {
        _interactManager = GetComponent<InteractManager>();

        playerTransform = GetComponent<Transform>();
        _interactManager.OnInteractableTriggered += CollectScaleChanger;
    }

    private void CollectScaleChanger(IInteractable interactable)
    {
        if (interactable is ColorCollectable colorCollectable)
        {
            if (PlayerColorChanger.PlayerColor == colorCollectable.MyColor ||
             Colors.Green == colorCollectable.MyColor)
            {
                playerTransform.localScale *= colorCollectable.ScaleIncreaseAmount;
            }
            else
            {
                playerTransform.localScale /= colorCollectable.ScaleIncreaseAmount;
            }
        }
    }
}
