using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlace : Interactable
{
    private bool woodUsed = false;
    private bool waterUsed = false;


    public override void OnInteraction()
    {
        base.OnInteraction();
        if (!woodUsed && !Inventory.Instance.inventory.Contains("Wood"))
        {
            subtitle.SetText("Uma lareira, o fogo parece estar bem forte.");
            StartCoroutine(UpdateText());
        }
        else if (Inventory.Instance.inventory.Contains("Wood"))
        {
            subtitle.SetText("Coloquei o pedaço de madeira no fogo. Parece que algo\napareceu de dentro desta madeira! O que será?");
            StartCoroutine(UpdateText());
            Inventory.Instance.RemoveItem("Wood");
            woodUsed = true;
        }
        if (!woodUsed && Inventory.Instance.inventory.Contains("Glass of Water"))
        {
            subtitle.SetText("Joguei a água no fogo, porém ele reacendeu, talvez eu tenha\nque colocar algo no fogo antes?");
            StartCoroutine(UpdateText());
            Inventory.Instance.RemoveItem("Glass of Water");
            Inventory.Instance.AddItem("Glass");
        }
        if (woodUsed && !waterUsed && !Inventory.Instance.inventory.Contains("Glass of Water"))
        {
            subtitle.SetText("Coloquei o pedaço de madeira no fogo. Parece que algo\napareceu de dentro desta madeira!\nComo posso pegar sem me queimar?");
            StartCoroutine(UpdateText());
        }
        if (woodUsed && !waterUsed && Inventory.Instance.inventory.Contains("Glass of Water"))
        {
            subtitle.SetText("Joguei a água no fogo e consegui retirar algo de dentro\nParece ser a chave da entrada!");
            StartCoroutine(UpdateText());
            Inventory.Instance.AddItem("Entrance Key");
            waterUsed = true;
        }
        else if (Inventory.Instance.inventory.Contains("Entrance Key"))
        {
            subtitle.SetText("Encontrei a chave da entrada! Vou sair daqui!");
            StartCoroutine(UpdateText());
        }





    }
}
