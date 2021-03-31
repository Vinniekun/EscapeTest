using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : Interactable
{
    public override void OnInteraction()
    {
        base.OnInteraction();
        subtitle.SetText("Talvez essa TV seja util, porém não tem nenhum botão\npara trocar de canal nela.");
        StartCoroutine(UpdateText());
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
