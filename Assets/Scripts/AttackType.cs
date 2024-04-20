using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AttackType
{
    public bool attack(Entity attackingEntity);
}

public class SingleClosestTarget : AttackType
{
    Entity target;

    public bool attack(Entity attackingEntity)
    {
        Debug.Log("SingleClosestTarget attack");

        target = findClosestTarget(attackingEntity);

        if (target != null)
        {
            target.takeDamage(attackingEntity.damage);
            return true;
        }

        return false;
    }

    private Entity findClosestTarget(Entity attackingEntity)
    {
        Collider[] hitColliders = Physics.OverlapSphere(attackingEntity.transform.position, attackingEntity.range);

        Entity nearest = null;
        Entity temp;
        float nearDist = float.PositiveInfinity;
        for (int i = 0; i < hitColliders.Length; i++)
        {
            temp = hitColliders[i].transform.gameObject.GetComponent<Entity>();

            if (temp.family == attackingEntity.targetFamily)
            {
                Vector3 offset = attackingEntity.transform.position - hitColliders[i].transform.position;
                float thisDist = offset.sqrMagnitude;
                if (thisDist < nearDist)
                {
                    nearDist = thisDist;
                    nearest = temp;
                }   
            }
        }

        return nearest;
    }
}

public class SingleFurthestTarget : AttackType
{
    Entity target;

    public bool attack(Entity attackingEntity)
    {
        Debug.Log("SingleFurthestTarget attack");

        // this should be literally the same as single closest target attack

        return true;
    }

    private Entity findFurthestTarget(Entity attackingEntity)
    {
        // code for this is essentially the same as find closest target
        // but flip the math around to get the furthest target in range

        return null;
    }
}

public class AreaOfEffect : AttackType
{
    List<Entity> targets;

    public bool attack(Entity attackingEntity)
    {
        Debug.Log("AreaOfEffect attack");

        // this will need to loop over the list of targets
        // and call takedamage on each of them
        // return true if literally any of the attacks succeed
        // (aka: if the list contains. anything)

        return true;
    }

    private List<Entity> getTargetsInRangeOfPosition(Entity attackingEntity)
    {
        // this should probably just do the normal loop over the colliders
        // and instead of checking for closest for furthest
        // just add everything in range with the right target family to a list
        // the return the list

        return new List<Entity>();
    }
}
