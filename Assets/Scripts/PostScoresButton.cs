using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostScoresButton : MonoBehaviour
    {
     public GameObject playerObject;
     private GameManager gameManager;

     // Start is called before the first frame update
     void Start()
        {
         gameManager = playerObject.GetComponent<GameManager>();
        }

     // Update is called once per frame
     void Update()
        {
        
        }

     public void onClickFun()
        {
         gameManager.promptForLeaderboardEntry();
        }
    }
