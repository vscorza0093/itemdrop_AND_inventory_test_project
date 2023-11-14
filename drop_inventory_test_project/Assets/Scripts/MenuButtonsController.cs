using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsController : MonoBehaviour
{
    [SerializeField]
    GameObject player;


    public void SetActivateColor(int index)
    {
        this.GetComponent<Image>().color = new Color32(0, 255, 255, 170);
        player.GetComponent<PlayerMenu>().menuBackground[index].SetActive(true);
    }

    public void DeactivateOtherButtons(int index)
    {
        GameObject[] menuButtons = GameObject.FindGameObjectsWithTag("MenuButton");
        foreach (var item in menuButtons)
        {
            if (item.gameObject.name != this.gameObject.name)
                item.GetComponent<Image>().color = Color.white;
        }

        for (int i = 0; i < player.GetComponent<PlayerMenu>().menuBackground.Length; i++)
        {
            if (i != index)
            {
                player.GetComponent<PlayerMenu>().menuBackground[i].SetActive(false);
            }
        }
    }
}
