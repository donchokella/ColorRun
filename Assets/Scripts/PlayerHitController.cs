using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitController : MonoBehaviour
{
    [SerializeField] private InteractManager interactManager;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _gameOverObject;

    private void Start()
    {
        interactManager.OnInteractableCollided += ControlHit;
    }

    private void ControlHit(IInteractable interactable)
    {
        if (interactable is IObstacle obstacle)
        {
            PlayerController.GeneralSpeedAspect = 0;
            _animator.SetTrigger("Finish");
            _gameOverObject.SetActive(true);
        }
    }
}
