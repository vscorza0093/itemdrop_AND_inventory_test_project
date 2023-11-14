using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PlayerMenu : MonoBehaviour
{
    [SerializeField]
    GameObject menuObject;
    [SerializeField]
    public GameObject[] menuBackground;

    [SerializeField]
    GameObject[] menuButtons;

    private bool isMenuOpen = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKeyDown(KeyCode.E) && !isMenuOpen)
                OpenMenu();
            else if (Input.GetKeyDown(KeyCode.E) && isMenuOpen)
                CloseMenu();
        }
    }

    void OpenMenu()
    {
        menuObject.SetActive(true);
        menuBackground[0].SetActive(true);
        menuButtons[0].GetComponent<Image>().color = new Color32(0, 255, 255, 170);
        isMenuOpen = true;
    }

    void CloseMenu()
    {
        ResetMenuSettings();
        menuObject.SetActive(false);
        isMenuOpen = false;
    }

    void ResetMenuSettings()
    {
        foreach (var item in menuButtons)
            item.GetComponent<Image>().color = Color.white;

        foreach (var item in menuBackground)
            item.SetActive(false);
    }

}
