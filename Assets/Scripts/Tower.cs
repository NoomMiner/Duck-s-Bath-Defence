using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Entity
{
    private int currentLevel = 1;
    public int maxLevel;
    public int cost;
    public int upgradeCost;

    public bool placeTower()
    {
        // TODO: place tower on grid if player has enough money
        // return true if player could afford it/was successful, false if not

        return true;
    }

    public bool upgrade()
    {
        // TODO: also check if player has enough money to do this
        if (currentLevel < maxLevel)
        {
            currentLevel++;

            // TODO: take player's money, upgrade other stats

            return true;
        }

        return false;
    }
}
