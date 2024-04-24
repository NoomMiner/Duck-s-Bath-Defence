using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tower : Entity
{
    public GameObject tiles;
    private bool placementMode = true;
    private float lastAttack = 0;

    void Update()
    {
        if (!placementMode)
        {
            if (Time.time - lastAttack > attackCooldown)
            {
                this.getAttackType().attack(this);
                lastAttack = Time.time;
            }
        }
        else
        {
            //this.gameObject.transform.position = Input.mousePosition;

            if (Input.GetMouseButtonDown(0))
            {
                placementMode = !placeTower(Input.mousePosition);
            }
        }
    }

    public bool placeTower(Vector3 positionToPlace)
    {
        // TODO: place tower on grid
        // return true if player could afford it/was successful, false if not
        Debug.Log("Trying to place on " + positionToPlace);
        Debug.Log("Tile value: " + tiles.GetComponent<PlacementTiles>().getGrid().GetValue(positionToPlace));

        // tileAvailable will be a status of all tiles. If true, the tile can have a tower placed on it
        if(tiles.GetComponent<PlacementTiles>().getGrid().GetValue(positionToPlace))
        {
            // Search for available spot to place or cancellation
            this.gameObject.transform.position = positionToPlace;
            tiles.GetComponent<PlacementTiles>().getGrid().SetValue(positionToPlace, false);
            return true;

            // Display confirmation button
            // Check to see if confirmation has been given
            /*
            if(confirmationClick)
                {
                    // Place tower at tile coordinate and mark spot availability to false

                    // Return success
                    return true;

                }
            */
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
