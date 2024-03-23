using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostScoresButton : MonoBehaviour
    {
     public GameObject playerObject;
     private PlayerType playerScript;

     // Start is called before the first frame update
     void Start()
        {
         playerScript = playerObject.GetComponent<PlayerType>();
        }

     // Update is called once per frame
     void Update()
        {
        
        }

     public void onClickFun()
        {
         playerScript.promptForLeaderboardEntry();
        }
    }
