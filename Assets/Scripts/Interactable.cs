using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    [SerializeField] public GameObject textArea;
    [SerializeField] public TMP_Text subtitle;

    public virtual void OnInteraction()
    {
        
    }

    public virtual IEnumerator UpdateText(float time)
    {
        textArea.SetActive(true);
        yield return new WaitForSecondsRealtime(time);
        textArea.SetActive(false);
        subtitle.SetText("");
    }

    public virtual IEnumerator UpdateText()
    {
        textArea.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        textArea.SetActive(false);
        subtitle.SetText("");
    }

    public virtual IEnumerator RemoveAfterSeconds(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        gameObject.SetActive(false);
    }


}
