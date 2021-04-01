using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : Interactable
{
    public static bool startedToiletPuzzle = false;

    public override void OnInteraction()
    {
        base.OnInteraction();

        if (!Inventory.Instance.tvPuzzle)
        {
            subtitle.SetText("Tento dar a descarga mas parece não funcionar.");
            StartCoroutine(UpdateText());
        }
        else
        {
            if (Inventory.Instance.tvPuzzle)
            {
                subtitle.SetText("Dei a descarga e nada aconteceu.\nParece que tem uma pista na TV...");
                StartCoroutine(UpdateText());
            }
            if(Inventory.Instance.toiletPuzzle)
            {
                subtitle.SetText("Já resolvi este quebra-cabeça. Agora a casa\npossui água. O que posso fazer com água?");
                StartCoroutine(UpdateText());
            }
            else if (Inventory.Instance.toiletFinishing)
            {
                subtitle.SetText("O botão funcionou! Consigo ouvir o barulho de água\npela casa agora, o que posso fazer com água?");
                StartCoroutine(UpdateText());
                Inventory.Instance.toiletPuzzle = true;
            }
        }

        
    }
}
