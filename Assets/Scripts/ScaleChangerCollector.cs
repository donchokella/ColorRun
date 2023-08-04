using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScaleChangerCollector : MonoBehaviour
{
    [SerializeField] private InteractManager interactManager;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float scaleIncrement = 1.2f;


    private void Start()
    {
        playerTransform = GetComponent<Transform>();
        interactManager.OnInteractableTriggered += CollectScaleChanger;
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
