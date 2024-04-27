using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEditor.Build.Content;

public class DrainTest
{
    GameManager gameManager;
    GameObject drainObj;
    Tower drain;
    PlacementTiles tiles;

    [SetUp]
    public void SetUp()
    {
        GameObject gmObj = new GameObject("GameManager");
        GameObject tileObj = new GameObject();
        GameObject drainObj = new GameObject("Drain");
        GameObject fillerObj = new GameObject();
        drainObj.tag = "TestDrain";
        
        drain = drainObj.AddComponent<Tower>();
        tiles = tileObj.AddComponent<PlacementTiles>();
        gameManager = gmObj.AddComponent<GameManager>();
        gameManager.drainPrefab = drainObj;
        gameManager.tileAvailability = tileObj;
        gameManager.leaderboardEntryCreator = fillerObj;
        gameManager.playerCameraObject = fillerObj;
        gameManager.startGame();
    }

    [Test]
    public void verifyGameManager()
    {
        Assert.IsNotNull(gameManager);
    }

    [Test]
    public void verifyDrain()
    {
        Assert.IsNotNull(drain);
    }

    [Test]
    public void verifyTiles()
    {
        Assert.IsNotNull(tiles);
    }

    [Test]
    public void verifyGameStart()
    {
        Assert.IsTrue(gameManager.getGameActive());
    }

    [UnityTest]
    public IEnumerator gameOverWhenDrainDead()
    {
        // kill the drain, ensure it is connected to game manager
        drain = GameObject.FindGameObjectWithTag("TestDrain").GetComponent<Tower>();
        gameManager.drain = drain;
        drain.gameManager = gameManager;
        drain.die();

        // wait a second for it to register
        yield return new WaitForSeconds(1);

        // check if the game ended
        Assert.IsFalse(gameManager.getGameActive());
    }
}
