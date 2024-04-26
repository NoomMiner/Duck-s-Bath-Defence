using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class uiElementscripts : MonoBehaviour
{
    //declare variables
    public GameManager gameManager;

    GameObject CurrencyObj;
    GameObject ScoreObj;


    GameObject[] uiElements;


    // Start is called before the first frame update
    void Start()
    {
        //initializes gameManager
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");

        //checks if GameManager found
        if (gameManagerObject != null)
        {
            Debug.Log("FOUND MANAGER");
            gameManager = gameManagerObject.GetComponent<GameManager>();
        }
        else
        {
            Debug.Log("MANAGER NOT FOUND");
        }

        //gets all UIElements
        uiElements = GameObject.FindGameObjectsWithTag("UIElement");
        
        //find Score and Currency labels
        for (int i = 0;  i < uiElements.Length; i++)
        {
            if ("CurrencyLabel" == uiElements[i].name)
            {
                CurrencyObj = uiElements[i];
            }
            if ("ScoreLabel" == uiElements[i].name)
            {
                ScoreObj = uiElements[i];
            }
        }

        //initialize score and currency
        int score = gameManager.getScore();
        int currency = gameManager.getCurrency();

        Debug.Log("TEXT CURRENCY: " + CurrencyObj.GetComponent<TMP_Text>().text);

        ScoreObj.GetComponent<TMP_Text>().text = "Score: " + score;
        CurrencyObj.GetComponent<TMP_Text>().text = "Currency: " + currency;

    }
    // Update is called once per frame
    void Update()
    {
        //get score and currency
        int score = gameManager.getScore();
        int currency = gameManager.getCurrency();
        
        //if labels found then replaces label text
        if (ScoreObj != null && CurrencyObj != null)
        {
            ScoreObj.GetComponent<TMP_Text>().text = "Score: " + score;
            CurrencyObj.GetComponent<TMP_Text>().text = "Currency: " + currency;
        }
        
    }
}
