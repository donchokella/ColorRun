using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour, IInteractable
{
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _coinText;

    private void AddCoin()
    {
        gameObject.SetActive(false);

        _score++;
        _coinText.text = "Score: " + _score.ToString();
    }

    public void InteractLogic()
    {
        AddCoin();
    }
}
