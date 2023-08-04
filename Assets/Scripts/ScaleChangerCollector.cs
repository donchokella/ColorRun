using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScaleChangerCollector : MonoBehaviour
{
    [SerializeField] private InteractManager interactManager;

    public Action OnScaleChange;

    private void Start()
    {
        interactManager.OnInteractableTriggered += CollectScaleChanger;
    }

    private void CollectScaleChanger(IInteractable interactable)
    {
        if (interactable is IScaleChanger scaleChanger)
        {
            scaleChanger.BeCollected();
            OnScaleChange?.Invoke();
        }
    }

}
