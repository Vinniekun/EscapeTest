using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomDoor : Interactable
{
    public Animator anim;
    public BoxCollider bc;
    public bool opened = false;

    public override void OnInteraction()
    {
        base.OnInteraction();

        if (!opened) {
            if (Inventory.Instance.inventory.Contains("Bedroom Key"))
            {
                bc.enabled = false;
                anim.Play("BedroomDoorOpen");
                opened = true;
            }
        }
        
        

    }


}
