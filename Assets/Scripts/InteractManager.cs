using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractManager : MonoBehaviour
{
    public Action<IInteractable> OnInteractableTriggered;
    public Action<IInteractable> OnInteractableCollided;


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        IInteractable interactable = other.gameObject.GetComponent<IInteractable>();
        if (interactable != null)
        {
            OnInteractableTriggered.Invoke(interactable);

        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        IInteractable interactable = other.gameObject.GetComponent<IInteractable>();
        if (interactable != null)
        {
            OnInteractableCollided?.Invoke(interactable);
        }
    }
}
