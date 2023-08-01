using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _coinText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("FinLine"))
        {
            Debug.Log("finnnn");
            PlayerController playerController = gameObject.GetComponent<PlayerController>();
            playerController.SetRunningSpeed(0);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("obs!!!");
        }
    }

    private void AddCoin()
    {
        _score++;
        _coinText.text = "Score: " + _score.ToString();
    }
}
