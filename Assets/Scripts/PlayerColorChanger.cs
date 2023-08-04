using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorChanger : MonoBehaviour
{
    public static Colors PlayerColor { get; private set; }
    [SerializeField] private InteractManager interactManager;
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;

    private void Start()
    {
        PlayerColor = Colors.Blue;
        interactManager.OnInteractableTriggered += ChangeColor;
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
