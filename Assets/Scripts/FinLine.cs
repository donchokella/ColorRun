using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinLine : MonoBehaviour, IInteractable
{
    [SerializeField] private PlayerController playerController;

    private void FinishGame()
    {
        Debug.Log("finnnn");
        playerController.SetRunningSpeed(0);
    }
    public void InteractLogic()
    {
        FinishGame();
    }
}
