using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    [SerializeField]
    KeyCode key;

    [SerializeField]
    string itemType;

    private GameObject player;

    [SerializeField]
    GameObject inventoryItem;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void InstantiateItemAtInventory()
    {
        player.GetComponent<Inventory>().CheckItemToInstantiate(inventoryItem, itemType);
    }

    public void PickItem()
    {
        InstantiateItemAtInventory();
        Destroy(this.gameObject);
    }
}
