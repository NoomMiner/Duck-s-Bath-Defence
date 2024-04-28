using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile 
{
    public int x; 
    public int y;
    public bool isAvailable;


    public Tile(int x, int y, bool isAvailable)
    {
        this.x = x; 
        this.y = y; 
        this.isAvailable = isAvailable;
    }

    public Tile setAvailable(bool isAvailable)
    {
        this.isAvailable = isAvailable;
        return this;
    }

    public Vector2 getTileCoord()
    {
        return new Vector2(x, y);
    }

}
