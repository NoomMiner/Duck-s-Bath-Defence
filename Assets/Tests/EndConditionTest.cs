using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEditor.Build.Content;

public class EndConditionTest
{
    GameManager gameManager;
    Tower drain;

    [SetUp]
    public void SetUp()
    {
        SceneManager.LoadScene("Scenes/TestEnvironment");

        GameObject gameManagerObj = new GameObject("GameManager");
        gameManagerObj.tag = "GameManager";
        gameManagerObj.AddComponent<GameManager>();
        gameManager = gameManagerObj.GetComponent<GameManager>();

        GameObject drainObj = new GameObject("Drain");
        drainObj.tag = "GameManager";
        drainObj.AddComponent<Tower>();
        drain = drainObj.GetComponent<Tower>();
        drain.gameManager = gameManager;

        gameManager.drainPrefab = drainObj;
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

    [UnityTest]
    public IEnumerator gameOverWhenDrainDead()
    {
        // kill the drain
        drain.takeDamage(drain.maxHealth);

        // wait a second for it to register
        yield return new WaitForSeconds(1);

        // check if the game ended
        Assert.IsFalse(gameManager.getGameActive());
    }
}
