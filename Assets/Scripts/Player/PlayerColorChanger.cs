using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorChanger : MonoBehaviour
{
    public static Colors PlayerColor { get; private set; }

    private InteractManager _interactManager;

    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;

    private void Start()
    {
        _interactManager = GetComponent<InteractManager>();

        PlayerColor = Colors.Blue;
        _interactManager.OnInteractableTriggered += ChangeColor;
    }

    private void ChangeColor(IInteractable interactable)
    {
        if (interactable is IGate gate)
        {
            (Color clr, Colors colorenum) = gate.MyColor();
            skinnedMeshRenderer.material.color = clr;
            PlayerColor = colorenum;
        }
    }
}
