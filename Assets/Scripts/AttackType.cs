using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AttackType
{
    public bool attack();
}

public class SingleClosestTarget : AttackType
{
    public bool attack()
    {
        return true;
    }

    private Entity findClosestTarget()
    {
        return null;
    }
}

public class SingleFurthestTarget : AttackType
{
    public bool attack()
    {
        return true;
    }

    private Entity findFurthestTarget()
    {
        return null;
    }
}

public class AreaOfEffect : AttackType
{
    public bool attack()
    {
        return true;
    }

    private List<Entity> getTargetsInRangeOfPosition(Transform tPosition)
    {
        return new List<Entity>();
    }
}