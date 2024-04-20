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
    // Start is called before the first frame update
    bool menuOpen = false;
    public GameManager gameManager;

    void Start()
    {

        this.gameObject.SetActive(false);
        menuOpen = false;

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

    //Either opens or closes the menu
    public void onclick()
    {
        //if (this.GetComponent<SpriteRenderer>().color == Color.green)
        if (menuOpen == true)
        {
            this.gameObject.SetActive(false);
            //this.GetComponent<SpriteRenderer>().color = Color.red;
            menuOpen = false;
        }
        else
        {
            this.gameObject.SetActive(true);
            //this.GetComponent<SpriteRenderer>().color = Color.green;
            menuOpen = true;
        }
    }


    public void Tower1OnClick()
    {
        if (gameManager.getCurrency() >= 100)
        {
            gameManager.RemoveCurrency(100);
        }
    }
}
