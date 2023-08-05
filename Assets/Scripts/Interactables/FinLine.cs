using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinLine : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GameManager _gameManager;

    private void FinishGame()
    {
        _animator.SetTrigger("Finish");
        PlayerController.GeneralSpeedAspect = 0;
        _gameManager.NextScene();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FinishGame();
        }
    }


}
