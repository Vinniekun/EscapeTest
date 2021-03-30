using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassWater : Interactable
{
    public override void OnInteraction()
    {
        base.OnInteraction();
        transform.position = new Vector3(0f, -20f, 0);
        subtitle.SetText("Um copo vazio. Será que nessa casa tem água?");
        StartCoroutine(UpdateText());
        Inventory.Instance.AddItem("Glass");
        StartCoroutine(RemoveAfterSeconds(6f));
    }

    public override IEnumerator RemoveAfterSeconds(float time)
    {
        return base.RemoveAfterSeconds(time);
    }

    public override IEnumerator UpdateText()
    {
        return base.UpdateText();
    }
}
