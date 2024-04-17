using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
    {
     // public fields
     public int currentScore;
     public int currentWave;
     public string currentMode;
     public GameObject leaderboardEntryCreator;
     public GameObject errorScreen;
     public GameObject playerCameraObject;

     // Start is called before the first frame update
     void Start()
        {
        
        }

     // Update is called once per frame
     void Update()
        {
         
        }

     // prompts the player to create a leaderboard entry
     public void promptForLeaderboardEntry()
        {
         GameObject newPrompt = Instantiate(leaderboardEntryCreator);
         LeaderboardUIControl uiControl;

         if (newPrompt.TryGetComponent<LeaderboardUIControl>(out uiControl))
            {
             uiControl.score = currentScore;
             uiControl.wave = currentWave;
             uiControl.mode = currentMode;
            }
         else
            {
             Debug.Log("There was an error prompting for leaderboard entry.");
            }
        }
    }
