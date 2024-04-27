using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEditor.Build.Content;

public class AttackTest
{
    Tower tower;
    Enemy enemy;

    [SetUp]
    public void SetUp()
    {
        GameObject towerObj = new GameObject("Tower");
        GameObject enemyObj = new GameObject("Enemy");

        tower = towerObj.AddComponent<Tower>();
        tower.range = 1000;
        tower.damage = 20;
        tower.maxHealth = 1000;
        tower.attackCooldown = 1;
        tower.family = TargetFamily.Tower;
        tower.targetFamily = TargetFamily.Enemy;

        enemy = enemyObj.AddComponent<Enemy>();
        enemy.range = 1000;
        enemy.damage = 20;
        enemy.maxHealth = 1000;
        enemy.attackCooldown = 1;
        tower.family = TargetFamily.Enemy;
        tower.targetFamily = TargetFamily.Tower;
    }

    [UnityTest]
    public IEnumerator towerLostHealth()
    {
        yield return new WaitForSeconds(2);
        Assert.IsFalse(tower.getCurrentHealth() == tower.maxHealth);
    }

    [UnityTest]
    public IEnumerator enemyLostHealth()
    {
        yield return new WaitForSeconds(2);
        Assert.IsFalse(enemy.getCurrentHealth() == enemy.maxHealth);
    }
}