using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // [SerializeField]
    // public Dictionary<GameObject, int> itemsToDrop = new Dictionary<GameObject, int>();

    [SerializeField]
    GameObject[] itemsToDrop;
    [SerializeField]
    int[] dropRate;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetDropChance();
            DestroyGameObject();
        }
    }

    void GetDropChance()
    {
        int i = 0;

        foreach (var item in itemsToDrop)
        {
            int randomNumber = Random.Range(0, 1000);
            CheckDropItemRate(randomNumber, i);
            i++;
        }
    }

    void CheckDropItemRate(int randomNumber, int index)
    {
        print($"Random Num: {randomNumber}, index {index}");
        if (randomNumber >= dropRate[index])
            InstantiateDroppedItem(index);
    }

    void InstantiateDroppedItem(int index)
    {
        Instantiate(itemsToDrop[index]);
    }

    void DestroyGameObject()
    {
        Destroy(this.gameObject);
    }
}