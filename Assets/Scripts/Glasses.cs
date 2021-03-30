using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class Glasses : Interactable
{

    public Volume v;

    public override void OnInteraction()
    {
        base.OnInteraction();
        transform.position = new Vector3(0f, -20f, 0);
        subtitle.SetText("Aqui está o meu óculos, agora posso enxergar melhor.");
        StartCoroutine(UpdateText());
        ClearImage();
        StartCoroutine(RemoveAfterSeconds(6));

    }

    public override IEnumerator RemoveAfterSeconds(float time)
    {
        return base.RemoveAfterSeconds(time);
    }

    public override IEnumerator UpdateText()
    {
        return base.UpdateText();
    }

    public void ClearImage()
    {
        v.profile.components[0].active = false;

    }

}
