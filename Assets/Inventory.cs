using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    [SerializeField] public List<string> inventory;
    public TMP_Text items;
    public bool bathroomPuzzle = false;
    public bool tvPuzzle = false;
    public bool toiletPuzzle = false;
    public bool toiletFinishing = false;
    public GameObject sceneObjects;
    public GameObject player;

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
            DontDestroyOnLoad(transform.gameObject);
            Instance = this;
        }
    }

    public void ChangeScene(bool change)
    {
        sceneObjects.SetActive(change);
    }

}
