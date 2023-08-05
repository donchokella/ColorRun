using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifierGate : MonoBehaviour, IInteractable, IGate
{

    [SerializeField] private Colors gateColor;
    public (Color, Colors) MyColor()
    {
        switch (gateColor)
        {
            case Colors.Blue:
                return (ColorPalette.Instance.Blue, Colors.Blue);
            case Colors.Purple:
                return (ColorPalette.Instance.Purple, Colors.Purple);
            case Colors.Orange:
                return (ColorPalette.Instance.Orange, Colors.Orange);
        }
        return (Color.blue, Colors.Blue);
    }
}
