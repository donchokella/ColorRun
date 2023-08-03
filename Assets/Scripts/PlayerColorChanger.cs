using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorChanger : MonoBehaviour
{
    [SerializeField] private InteractManager interactManager;
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;

    private void Start()
    {
        interactManager.OnInteractableTriggered += ChangeColor;
    }

    private void ChangeColor(IInteractable interactable)
    {
        if (interactable is IGate gate)
        {
            skinnedMeshRenderer.material.color = gate.MyColor();
        }
    }


}
