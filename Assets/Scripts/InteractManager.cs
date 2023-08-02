using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractManager : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        IInteractable interactable = other.gameObject.GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactable.InteractLogic();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        IInteractable interactable = other.gameObject.GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactable.InteractLogic();
        }
    }
}
