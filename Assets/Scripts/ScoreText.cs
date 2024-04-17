using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreText : MonoBehaviour
    {
     public GameObject playerObject;
     private TMP_Text scoreText;
     private GameManager gameManager;

     // Start is called before the first frame update
     void Start()
        {
         scoreText = this.gameObject.GetComponent<TMP_Text>();
         gameManager = playerObject.GetComponent<GameManager>();
        }

    // Update is called once per frame
     void Update()
        {
         scoreText.SetText("Score: " + gameManager.currentScore);
        }
    }
