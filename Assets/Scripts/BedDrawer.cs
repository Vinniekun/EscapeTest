using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedDrawer : Interactable
{

    public AnimationClip clip;
    public Animator anim;
    public GameObject key;
    private bool opened = false;
    
    public override void OnInteraction()
    {
        if (!opened)
        {
            key.layer = 8;
            anim.Play("DrawOpen2");
            opened = true;
        }
        else
        {
            key.layer = 0;
            anim.Play("DrawClose2");
            opened = false;
        }
        
    }
    





}
