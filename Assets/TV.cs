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

        if (!Inventory.Instance.inventory.Contains("Remote Control"))
        {
            subtitle.SetText("Talvez essa TV seja util, porém não tem nenhum botão\npara trocar de canal nela.");
            StartCoroutine(UpdateText());
        }
        else
        {
            if (!Inventory.Instance.tvPuzzle)
            {
                Cursor.lockState = CursorLockMode.None;
                Inventory.Instance.ChangeScene(false);
                Inventory.Instance.player.SetActive(false);
                SceneManager.LoadScene("TVPuzzle", LoadSceneMode.Additive);
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
