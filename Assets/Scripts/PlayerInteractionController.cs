using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractionController : MonoBehaviour
{
    private float maxDistance;
    public LayerMask interactableLayers;
    public Button interactButton;
    public Interactable currentInteractable;
    public GameObject interactableObject;

    void Start()
    {
        maxDistance = 2;
        interactableObject = null;
    }

    
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, maxDistance, interactableLayers))
        {
            currentInteractable = hit.collider.GetComponent<Interactable>();
            interactableObject = hit.collider.gameObject;
            //Debug.Log(interactableObject);
        }
        else
        {
            currentInteractable = null;
            interactableObject = null;
        }
        //interactButton.interactable = currentInteractable != null;

        if (currentInteractable)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Interact();
            }
        }

    }

    public void Interact()
    {
        if (currentInteractable)
        {
            currentInteractable.OnInteraction();
        }
    }

}
