using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using Image = UnityEngine.UI.Image;
using TMPro;
public class Inventory : MonoBehaviour
{
    public int[] itemCounter;

    [SerializeField]
    GameObject[] itemSlots;

    [SerializeField]
    GameObject[] items;

    [SerializeField]
    GameObject[] equipmentSlots;

    [SerializeField]
    GameObject[] equipments;

    [SerializeField]
    GameObject[] miscellaneousSlots;

    [SerializeField]
    GameObject[] miscellaneous;

    [SerializeField]
    TMP_Text[] slotQuantityText;

    public void CheckItemToInstantiate(GameObject gameObject, string itemType)
    {
        switch (itemType)
        {
            case "Item":
                InstantiateItemOnInventory(gameObject);
                break;
            case "Equipment":
                InstantiateEquipmentOnInventory(gameObject);
                break;
            case "Miscellaneous":
                InstantiateMiscellaneousOnInventory(gameObject);
                break;
            default:
                break;
        }
    }

    void InstantiateItemOnInventory(GameObject gameObject)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != null && items[i].name == gameObject.name)
            {
                itemCounter[i]++;
                slotQuantityText[i].text = itemCounter[i].ToString();
                break;
            }

            if (items[i] == null)
            {
                items[i] = Instantiate(gameObject, itemSlots[i].transform);
                ChangeItemSlotSettings(gameObject, i);
                ChangeItemSlotSpriteSettings(gameObject, i);
                itemCounter[i]++;
                slotQuantityText[i].text = itemCounter[i].ToString();
                break;
            }
        }
    }

    void ChangeItemSlotSettings(GameObject gameObject, int index)
    {
        items[index].name = gameObject.name;
    }

    void ChangeItemSlotSpriteSettings(GameObject gameObject, int index)
    {
        itemSlots[index].GetComponent<Image>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        itemSlots[index].GetComponent<Image>().color = Color.white;
    }

    void InstantiateEquipmentOnInventory(GameObject gameObject)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (equipments[i] == null)
            {
                equipments[i] = Instantiate(gameObject, equipmentSlots[i].transform);
                ChangeEquipmentSlotSettings(gameObject, i);
                ChangeEquipmentSlotSpriteSettings(gameObject, i);
                break;
            }
        }
    }

    void ChangeEquipmentSlotSettings(GameObject gameObject, int index)
    {
        equipments[index].name = gameObject.name;
    }

    void ChangeEquipmentSlotSpriteSettings(GameObject gameObject, int index)
    {
        equipmentSlots[index].GetComponent<Image>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        equipmentSlots[index].GetComponent<Image>().color = Color.white;
    }

    void InstantiateMiscellaneousOnInventory(GameObject gameObject)
    {

    }
}
