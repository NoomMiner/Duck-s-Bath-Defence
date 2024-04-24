using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{

    public int pointValue;

    // TODO: enemy must move along path on the grid somehow

    public override void die()
    {
        if (gameManager != null)
        {
            gameManager.enemyDeath(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

 
}
