using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreText : MonoBehaviour
    {
     public GameObject playerObject;
     private TMP_Text scoreText;
     private PlayerType playerScript;

     // Start is called before the first frame update
     void Start()
        {
         scoreText = this.gameObject.GetComponent<TMP_Text>();
         playerScript = playerObject.GetComponent<PlayerType>();
        }

    // Update is called once per frame
     void Update()
        {
         scoreText.SetText("Score: " + playerScript.currentScore);
        }
    }
