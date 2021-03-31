using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : Interactable
{
    public bool startedToiletPuzzle = false;
    public bool toiletPuzzleComplete = false;
    public bool toiletPuzzleDone = false;

    public override void OnInteraction()
    {
        base.OnInteraction();

        if (!startedToiletPuzzle)
        {
            subtitle.SetText("Tento dar a descarga mas parece não funcionar.");
            StartCoroutine(UpdateText());
        }
        else
        {
            if (!toiletPuzzleComplete)
            {
                subtitle.SetText("Dei a descarga e nada aconteceu.\nParece que tem uma pista na TV...");
                StartCoroutine(UpdateText());
            }
            else
            {
                subtitle.SetText("Já resolvi este quebra-cabeça.\n");
                StartCoroutine(UpdateText());
            }
        }

        
    }
}
