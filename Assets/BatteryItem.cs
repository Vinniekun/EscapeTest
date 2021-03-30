using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryItem : Interactable
{
    public override void OnInteraction()
    {
        base.OnInteraction();
        gameObject.transform.parent = null;
        transform.position = new Vector3(0f, -20f, 0);
        subtitle.SetText("Uma bateria. Posso usa em algo que precise de energia.");
        StartCoroutine(UpdateText());
        Inventory.Instance.AddItem("Battery");
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
