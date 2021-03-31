using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchPuzzle : Interactable
{
    public bool puzzleDone = false;

    public override void OnInteraction()
    {
        base.OnInteraction();
        
        if (!puzzleDone)
        {
            //SceneManager.LoadScene("SwitchPuzzle");
        }
        else
        {
            subtitle.SetText("Talvez essa TV seja util, porém não tem nenhum botão\npara trocar de canal nela.");
            StartCoroutine(UpdateText());
            SceneManager.LoadScene("TVPuzzle");
        }


    }
}
