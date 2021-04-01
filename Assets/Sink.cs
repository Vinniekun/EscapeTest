using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : Interactable
{

    public override void OnInteraction()
    {
        base.OnInteraction();

        if (!Inventory.Instance.inventory.Contains("Glass of Water"))
        {
            if (Inventory.Instance.toiletPuzzle)
            {
                if (!Inventory.Instance.inventory.Contains("Glass"))
                {
                    subtitle.SetText("A casa possui água agora, preciso de um recipiente para colocar ela.");
                    StartCoroutine(UpdateText());
                }
                else
                {
                    subtitle.SetText("Coloquei a água no copo que encontrei.");
                    StartCoroutine(UpdateText());
                    Inventory.Instance.RemoveItem("Glass");
                    Inventory.Instance.AddItem("Glass of Water");
                }
            }
            else
            {
                if (!Inventory.Instance.inventory.Contains("Glass"))
                {
                    subtitle.SetText("Essa pia não está funcionando, parece não ter água na casa.");
                    StartCoroutine(UpdateText());
                }
                else
                {
                    subtitle.SetText("Essa pia não está funcionando, não adinta colocar o copo.\nComo posso ligar o registro de água da casa?");
                    StartCoroutine(UpdateText());
                }
            }
        }
        else
        {
            subtitle.SetText("O copo que encontrei já possui água. Onde eu posso uso-lo agora?");
            StartCoroutine(UpdateText());
        }
    }


}
