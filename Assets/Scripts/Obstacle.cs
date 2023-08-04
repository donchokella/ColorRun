using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour, IInteractable, IObstacle
{
    [SerializeField] private GameObject gameOverScene;


    public void TakeDamage()
    {
        Debug.Log("obs!!!");
        gameOverScene.SetActive(true);
    }
}
