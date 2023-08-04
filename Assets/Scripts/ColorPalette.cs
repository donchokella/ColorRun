using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Colors
{
    Blue, Orange, Purple, Green, Red
}

public class ColorPalette : MonoBehaviour
{
    public static ColorPalette Instance;

    public Color Blue;
    public Color Orange;
    public Color Purple;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
