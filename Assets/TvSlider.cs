using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvSlider : Interactable
{
    public Animator anim;
    private bool opened = false;
    public GameObject battery;

    public override void OnInteraction()
    {
        base.OnInteraction();

        if (!opened)
        {
            anim.Play("TvSlider");
            opened = true;
            battery.layer = 8;
        }


    }
}
