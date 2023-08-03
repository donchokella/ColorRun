using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreChanger : MonoBehaviour
{
    [SerializeField] private CoinCollector coinCollector;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        coinCollector.OnCoinAmountChanged += ChangeScore;
    }

    private void ChangeScore(int coinAmount)
    {
        scoreText.text = "Score: " + coinAmount;
    }
}
