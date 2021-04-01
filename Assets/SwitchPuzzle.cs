using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchPuzzle : Interactable 
{

    public bool correctAngle = true;

    public override void OnInteraction()
    {
        base.OnInteraction();
        
        if (!Inventory.Instance.toiletPuzzle) { 
        
            transform.Rotate(new Vector3(15f, 0f, 0f));
            if (Mathf.Round(transform.rotation.eulerAngles.x) == 335)
            {
                Inventory.Instance.toiletFinishing = true;
            }
            else
            {
                Inventory.Instance.toiletFinishing = false;
            }

        }
        else
        {
            /*subtitle.SetText("Talvez essa TV seja util, porém não tem nenhum botão\npara trocar de canal nela.");
            StartCoroutine(UpdateText());
            */
        }


    }
}
