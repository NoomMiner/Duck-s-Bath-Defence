using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Entity
{
    public bool placeTower()
    {
        // TODO: place tower on grid
        // return true if player could afford it/was successful, false if not

        // tileAvailable will be a status of all tiles. If true, the tile can have a tower placed on it
        if(tileAvailable)
        {
            // Search for available spot to place or cancellation

            // Display confirmation button
            // Check to see if confirmation has been given
            if(confirmationClick)
                {
                    // Place tower at tile coordinate and mark spot availability to false

                    // Return success
                    return true;

                }
        }

        // Otherwise, return failure
 
        return false;
    }

    public override void die()
    {
        if (gameManager != null)
        {
            gameManager.towerDeath(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
