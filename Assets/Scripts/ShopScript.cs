using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.EventSystems;
using Color = UnityEngine.Color;
using Image = UnityEngine.UI.Image;

public class ShopScript : MonoBehaviour
{
    //initialize variables
    bool menuOpen;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //starts and initialize menu state
        this.gameObject.SetActive(false);
        menuOpen = false;

        //initialize GameManager
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");

        if (gameManagerObject != null)
        {
            gameManager = gameManagerObject.GetComponent<GameManager>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Either opens or closes the shop menu
    public void onclick()
    {
        if (menuOpen == true)
        {
            this.gameObject.SetActive(false);
            menuOpen = false;
        }
        else
        {
            this.gameObject.SetActive(true);
            menuOpen = true;
        }
    }

    //Chekcs when Tower1IsBought
    public void Tower1OnClick()
    {
        if (gameManager.getCurrency() >= 100)
        {
            gameManager.RemoveCurrency(100);
        }
    }

    //Activates when delete tower button is selected
    public void deleteTower()
    {

    }
}
