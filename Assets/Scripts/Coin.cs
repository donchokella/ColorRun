using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour, IInteractable, ICoin
{
    private int CoinAmount = 1;

    public void BeCollected()
    {
        gameObject.SetActive(false);
    }

    public int MyCount()
    {
        return CoinAmount;
    }
}
