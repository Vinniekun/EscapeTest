using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : Interactable
{
    public GameObject winPanel;


    public override void OnInteraction()
    {
        base.OnInteraction();

        if (Inventory.Instance.inventory.Contains("Entrance Key"))
        {
            Inventory.Instance.player.SetActive(false);
            winPanel.SetActive(true);
            
        }
        else
        {
            subtitle.SetText("Está trancada, preciso achar alguma maneira de sair deste lugar.");
            StartCoroutine(UpdateText());
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
