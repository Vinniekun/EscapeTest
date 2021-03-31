using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Interactable
{

    public override void OnInteraction()
    {
        base.OnInteraction();
        transform.position = new Vector3(0f, -20f, 0f);
        subtitle.SetText("Uma maçaneta de chuveiro. Devo coloca-la no banheiro?");
        StartCoroutine(UpdateText());
        Inventory.Instance.AddItem("Shower Switch");
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
