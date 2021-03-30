using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteControl : Interactable
{
    private bool hasBattery = false;

    public override void OnInteraction()
    {
        base.OnInteraction();

        if (hasBattery)
        {
            transform.position = new Vector3(0f, -20f, 0);
            subtitle.SetText("A bateria que encontrei coube no controle! Vou tentar usa-lo em algum lugar.");
            StartCoroutine(UpdateText());
            Inventory.Instance.AddItem("Remote Control");
            StartCoroutine(RemoveAfterSeconds(6f));
        }
        else
        {
            subtitle.SetText("Um controle remoto, mas parece estar sem bateria.");
            StartCoroutine(UpdateText());
            hasBattery = true;
        }

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
