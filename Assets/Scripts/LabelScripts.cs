using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LabelScripts : MonoBehaviour
{
    public GameManager gameManager;

    GameObject CurrencyObj;
    GameObject ScoreObj;

    GameObject[] labels;

    //int tw1, tw2, score, currency;

    // Start is called before the first frame update
    void Start()
    {
        //initializes gameManager
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");

        if (gameManagerObject != null)
        {
            Debug.Log("FOUND MANAGER");
            gameManager = gameManagerObject.GetComponent<GameManager>();
        }
        else
        {
            Debug.Log("MANAGER NOT FOUND");
        }

        labels = GameObject.FindGameObjectsWithTag("UIElement");
        
        for (int i = 0;  i < labels.Length; i++)
        {
            if ("CurrencyLabel" == labels[i].name)
            {
                CurrencyObj = labels[i];
            }
            if ("ScoreLabel" == labels[i].name)
            {
                ScoreObj = labels[i];
            }
        }

        Debug.Log("GOT OBJECT:" + CurrencyObj.name);
        Debug.Log("GOT OBJECT:" + ScoreObj.name);

        int score = gameManager.getScore();
        int currency = gameManager.getCurrency();

        Debug.Log("TEXT CURRENCY: " + CurrencyObj.GetComponent<TMP_Text>().text);

        ScoreObj.GetComponent<TMP_Text>().text = "Score: " + score;
        CurrencyObj.GetComponent<TMP_Text>().text = "Currency: " + currency;

    }
    // Update is called once per frame
    void Update()
    {
        int score = gameManager.getScore();
        int currency = gameManager.getCurrency();
        
        if (ScoreObj != null && CurrencyObj != null)
        {
            ScoreObj.GetComponent<TMP_Text>().text = "Score: " + score;
            CurrencyObj.GetComponent<TMP_Text>().text = "Currency: " + currency;
        }
        
    }
}
