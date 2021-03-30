using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinnerDoor1 : Interactable
{
    public Animator anim;
    public BoxCollider bc;
    private bool opened = false;
    public GameObject wood;

    public override void OnInteraction()
    {
        base.OnInteraction();

        if (!opened)
        {
            bc.enabled = false;
            anim.Play("DinnerDoor1Open");
            opened = true;
            wood.layer = 8;
        }


    }
}
