using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    [SerializeField] public List<string> inventory;
    public TMP_Text items;

    void Start()
    {
        inventory = new List<string>();
    }

    public void AddItem(string item)
    {
        inventory.Add(item);
        items.text += item + "\n";
    }

    public void RemoveItem(string item)
    {
        inventory.Remove(item);
        items.text = "";
        foreach (var it in inventory)
        {
            items.text += it + "\n";
        }
    }
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
}
