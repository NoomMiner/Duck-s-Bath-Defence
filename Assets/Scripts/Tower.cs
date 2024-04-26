using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tower : Entity
{
    public GameObject tiles;

    public int cost;
    public int id;

    public bool placeTower(Vector3 positionToPlace)
    {
        // TODO: place tower on grid
        // return true if player could afford it/was successful, false if not
        int x, y;
        tiles.GetComponent<PlacementTiles>().getGrid().GetXY(positionToPlace, out x, out y );

        Debug.Log("Trying to place on (" + x + ", " + y + ")");
        Debug.Log("Tile value: " + tiles.GetComponent<PlacementTiles>().getGrid().GetValue(x, y));

        // tileAvailable will be a status of all tiles. If true, the tile can have a tower placed on it
        if(tiles.GetComponent<PlacementTiles>().getGrid().GetValue(x, y))
        {
            Debug.Log("Placed tower");
            // Search for available spot to place or cancellation
            this.gameObject.transform.position = positionToPlace;
            tiles.GetComponent<PlacementTiles>().getGrid().SetValue(x, y, false);
            return true;
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