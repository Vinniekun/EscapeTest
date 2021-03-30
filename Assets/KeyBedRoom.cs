using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBedRoom : Interactable
{

    public override void OnInteraction()
    {
        base.OnInteraction();
        gameObject.transform.parent = null;
        transform.position = new Vector3(0f, -20f, 0);
        subtitle.SetText("Uma chave... parece utíl, vou guardá-la");
        StartCoroutine(UpdateText());
        Inventory.Instance.AddItem("Bedroom Key");
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
