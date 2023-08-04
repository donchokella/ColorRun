using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitController : MonoBehaviour
{
    [SerializeField] private InteractManager interactManager;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private SwerveMovement swerveMovement;
    [SerializeField] private Animator _animator;

    private void Start()
    {
        interactManager.OnInteractableCollided += ControlHit;
        swerveMovement = GetComponent<SwerveMovement>();
    }

    private void ControlHit(IInteractable interactable)
    {
        if (interactable is IObstacle obstacle)
        {
            obstacle.TakeDamage();
            playerController.SetRunningSpeed(0);
            swerveMovement.SwerveSpeed = 0;
            _animator.SetBool("IsHit", true);
        }
    }
}
