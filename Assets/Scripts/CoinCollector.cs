using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private InteractManager interactManager;
    private int _coinAmount = 0;
    public Action<int> OnCoinAmountChanged;


    private void Start()
    {
        interactManager.OnInteractableTriggered += CollectCoin;
    }


    private void CollectCoin(IInteractable interactable)
    {
        if (interactable is ICoin coin)
        {
            coin.BeCollected();
            _coinAmount += coin.MyCount();
            OnCoinAmountChanged.Invoke(_coinAmount);
        }
    }
}
