using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlace : Interactable
{
    public GameObject showerSwitch;

    public override void OnInteraction()
    {
        base.OnInteraction();
        if(!Inventory.Instance.inventory.Contains("Shower Switch"))
        {
            subtitle.SetText("Parece que alguma coisa se encaixa aqui.");
            StartCoroutine(UpdateText());
        }
        else
        {
            transform.position = new Vector3(0f, -20f, 0);
            showerSwitch.SetActive(true);
            subtitle.SetText("O maçaneta se encaixou, vamos ver o que eu posso fazer\nse eu mexer nela.");
            StartCoroutine(UpdateText());
            Inventory.Instance.RemoveItem("Shower Switch");
            StartCoroutine(RemoveAfterSeconds(6f));
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
