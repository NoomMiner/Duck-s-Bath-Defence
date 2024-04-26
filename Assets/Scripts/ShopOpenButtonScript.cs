using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Color = UnityEngine.Color;
using Image = UnityEngine.UI.Image;

public class ShopOpenButtonScript : MonoBehaviour
{

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().color = Color.green;
        //initializes gameManager
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");

        //checks if GameManager found
        if (gameManagerObject != null)
        {
            gameManager = gameManagerObject.GetComponent<GameManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //checks if tower is being place or deleted
        if (gameManager.isTowerHeld || gameManager.isDeleting)
        {
            this.GetComponentInChildren<TextMeshProUGUI>().text = "Cancel";
            this.GetComponent<Image>().color = Color.red;
        }
        else
        {
            this.GetComponentInChildren<TextMeshProUGUI>().text = "Shop";
            this.GetComponent<Image>().color = Color.green;
        }
    }

    //Switches shop from green to red
    public void onClick()
    {
        if (gameManager.isTowerHeld)
        {
            gameManager.isTowerHeld = false;
            gameManager.heldTower.gameObject.SetActive(false);
            gameManager.heldTower = null;

            gameManager.isTowerHeld = false;
        }
        else if (gameManager.isDeleting)
        {
            gameManager.isDeleting = false;
        }
        else if (this.GetComponent<Image>().color == Color.green)
        {

            this.GetComponent<Image>().color = Color.red;
        }
        else
        {
            this.GetComponent<Image>().color = Color.green;
        }


    }
}
