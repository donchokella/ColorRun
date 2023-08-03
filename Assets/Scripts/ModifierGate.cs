using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifierGate : MonoBehaviour, IInteractable, IGate
{
    [SerializeField] private PlayerController playerController;

    [SerializeField] private PlayerController.PlayerColor gateColor;

    public enum ModifierGateColor
    {
        Blue,
        Purple,
        Orange
    }


    public Color MyColor()
    {
        switch (gateColor)
        {
            case PlayerController.PlayerColor.Blue:
                return ColorPalette.Instance.Blue;
            case PlayerController.PlayerColor.Purple:
                return ColorPalette.Instance.Purple;
            case PlayerController.PlayerColor.Orange:
                return ColorPalette.Instance.Orange;

        }
        return Color.blue;
    }
}
