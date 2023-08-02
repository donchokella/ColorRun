using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour, IInteractable
{
    private void TakeDamage()
    {
        Debug.Log("obs!!!");
    }
    public void InteractLogic()
    {
        TakeDamage();
    }
}
