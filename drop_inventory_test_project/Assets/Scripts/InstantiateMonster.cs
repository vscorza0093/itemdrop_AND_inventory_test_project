using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateMonster : MonoBehaviour
{
    [SerializeField]
    GameObject monster;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            InstantiateGameObject(monster);
    }

    void InstantiateGameObject(GameObject monster)
    {
        Instantiate(monster);
    }
}
