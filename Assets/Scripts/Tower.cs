using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Entity
{
    public int cost;

    public bool placeTower()
    {
        // TODO: place tower on grid if player has enough money
        // return true if player could afford it/was successful, false if not

        return true;
    }

    public override void die()
    {
        if (gameManager != null)
        {
            gameManager.towerDeath(this);
        }
    }
}
