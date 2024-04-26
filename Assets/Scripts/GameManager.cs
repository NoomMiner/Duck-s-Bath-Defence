using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public enum GameMode {Test, Classic};

   // TODO: add game grid

   // public fields
   

   public int currentScore;
   public int currency;
   public int currentWave;
   public float timeBetweenWaves;
   public GameMode currentMode;
   public GameObject drainObject;
   public GameObject waveControllerObject;
   public GameObject leaderboardEntryCreator;
   public GameObject errorScreen;
   public GameObject playerCameraObject;

   public static GameManager main;
   public Transform startPointLeft;
   public Transform startPointRight;
   public Transform[] path;


    // private fields
   private float waveStartTime;
   private bool gameActive;
   private Tower drain;
    //private WaveController waveController;

    private void Awake()
    {
        main = this;
    }


    // Start is called before the first frame update
    void Start()
   {
      // TODO: Place drain tower at some position on the grid

      currentScore = 0;
      currency = 0;
      currentWave = 1;
      currentMode = GameMode.Test;
      gameActive = false;
      //waveController = waveControllerObject.GetComponent<WaveController>();
      if (drainObject != null)
      {
         drain = drainObject.GetComponent<Tower>();
      }
   }

   // Update is called once per frame
   void Update()
   {
      // check if the game is active
      if (gameActive)
      {
         // TODO:
         // check if all enemies are gone

            // current time less than wave start time -> schedule next wave

            // otherwise -> advance wave and start it (dependency: WaveController)
      }
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
         uiControl.mode = currentMode.ToString();
      }
      else
      {
         Debug.Log("There was an error prompting for leaderboard entry.");
      }
   }

   public bool getGameActive()
   {
      return gameActive;
   }

   public void startGame()
   {
      gameActive = true;
   }

   public void endGame()
   {
      gameActive = false;
      promptForLeaderboardEntry();
   }

   public void enemyDeath(Enemy enemy)
   {
      currentScore += enemy.pointValue;
      Destroy(enemy.gameObject);
   }

   public void towerDeath(Tower tower)
   {
      if (tower == drain)
      {
         endGame();
      }

      Destroy(tower.gameObject);
   }
}
