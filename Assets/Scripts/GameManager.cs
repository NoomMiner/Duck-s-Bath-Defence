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
   public GameObject drainPrefab;
   public GameObject waveControllerObject;
   public GameObject leaderboardEntryCreator;
   public GameObject errorScreen;
   public GameObject playerCameraObject;
   public GameObject tileAvailability;

   public Tower heldTower;
   public bool isTowerHeld;
   public int TowerCost;

   // private fields
   private float waveStartTime;
   private bool gameActive;
   public Tower drain;
   //private WaveController waveController;

   public static GameManager main;
   public Transform startPointLeft;
   public Transform startPointRight;
   public Transform[] path;

    private void Awake()
    {
        main = this;
    }

   // Start is called before the first frame update
   void Start()
   {
      // TODO: Place drain tower at some position on the grid

      currentScore = 10;
      currency = 300;
      currentWave = 1;
      currentMode = GameMode.Test;
      gameActive = false;
      //waveController = waveControllerObject.GetComponent<WaveController>();
      drain = Instantiate(drainPrefab).GetComponent<Tower>();
      drain.tiles = tileAvailability;
      
      drain.placeTower(drain.transform.position);
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


    public int getScore()
    {
        return currentScore;
    }

    //This function is meant to take a tower bought in the shop

    public int getCurrency()
    {
        return currency;
    }

    public void AddCurrency(int addedCurrency)
    {
        currency += addedCurrency;
    }

    public void RemoveCurrency(int removedCurrency)
    {
        currency -= removedCurrency;
    }

    //Is called when user buys a tower and it is being held
    public void acquireTower(Tower t1 ,int cost)
    {
        heldTower = t1;
        heldTower.tiles = tileAvailability;
        isTowerHeld = true;
        TowerCost = cost;
    }

    public bool getGameActive()
    {
      return gameActive;
    }
}
