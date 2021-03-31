using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TV : Interactable
{

    private bool controller = true;

    public override void OnInteraction()
    {
        base.OnInteraction();

        if (!controller)
        {
            subtitle.SetText("Talvez essa TV seja util, porém não tem nenhum botão\npara trocar de canal nela.");
            StartCoroutine(UpdateText());
        }
        else
        {
            if (!Inventory.Instance.tvPuzzle)
            {
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("TVPuzzle");
            }
            else
            {
                subtitle.SetText("Apareceu algo diferente na TV.\nPoderia ser uma pista?");
                StartCoroutine(UpdateText());
            }
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
