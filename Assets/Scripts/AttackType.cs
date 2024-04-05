using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AttackType
{
    public bool attack(Entity attackingEntity);
}

public class SingleClosestTarget : AttackType
{
    public bool attack(Entity attackingEntity)
    {
        Debug.Log("SingleClosestTarget attack");
        return true;
    }

    private Entity findClosestTarget()
    {
        return null;
    }
}

public class SingleFurthestTarget : AttackType
{
    public bool attack(Entity attackingEntity)
    {
        Debug.Log("SingleFurthestTarget attack");
        return true;
    }

    private Entity findFurthestTarget()
    {
        return null;
    }
}

public class AreaOfEffect : AttackType
{
    public bool attack(Entity attackingEntity)
    {
        Debug.Log("AreaOfEffect attack");
        return true;
    }

    private List<Entity> getTargetsInRangeOfPosition(Vector3 worldPosition)
    {
        return new List<Entity>();
    }
}