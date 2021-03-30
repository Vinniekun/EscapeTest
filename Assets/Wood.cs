using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : Interactable 
{ 

    public override void OnInteraction()
    {
        base.OnInteraction();
        transform.position = new Vector3(0f, -20f, 0);
        subtitle.SetText("Um pedaço de madeira? Parece que posso usar em algum lugar da casa.");
        StartCoroutine(UpdateText());
        StartCoroutine(RemoveAfterSeconds(6));
    }
}
