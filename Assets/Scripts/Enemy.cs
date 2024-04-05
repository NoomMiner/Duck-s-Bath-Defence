using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    public float speed;
    public int pointValue;

    // TODO: enemy must move along path on the grid somehow

    public override void die()
    {
        // TODO: award the player points

        Destroy(this.gameObject);
    }
}
