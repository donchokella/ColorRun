using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinLine : MonoBehaviour, IInteractable
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private SwerveMovement swerveMovement;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameManager gameManager;

    private void FinishGame()
    {
        Debug.Log("finnnn");
        playerController.SetRunningSpeed(0);
        gameManager.NextScene();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FinishGame();
            swerveMovement.SwerveSpeed = 0;
            _animator.SetBool("IsHit", true);
        }
    }


}
