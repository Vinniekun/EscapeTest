using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses : Interactable
{

    public override void OnInteraction()
    {
        base.OnInteraction();
        Debug.Log("Pegou os óculos");
    }

}
