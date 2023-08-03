using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private InteractManager interactManager;
    private int CoinAmount;

    public Action<int> OnCoinAmountChanged;

    private void Start()
    {
        interactManager.OnInteractableTriggered += CollectCoin;

    }

    private void CollectCoin(IInteractable interactable)
    {
        if(interactable is ICoin coin)
        {
            coin.BeCollected();
            CoinAmount += coin.MyCount();
            OnCoinAmountChanged.Invoke(CoinAmount);
        }
    }

}
