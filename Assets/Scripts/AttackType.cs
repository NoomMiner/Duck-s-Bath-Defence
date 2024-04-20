using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AttackType
{
    public bool attack(Entity attackingEntity);
}

public class SingleClosestTarget : AttackType
{
    GameObject target;

    public bool attack(Entity attackingEntity)
    {
        Debug.Log("SingleClosestTarget attack");

        target = findClosestTarget(attackingEntity);

        if (target != null)
        {
            target.GetComponent<Entity>().takeDamage(attackingEntity.damage);
            return true;
        }

        return false;
    }

    private GameObject findClosestTarget(Entity attackingEntity)
    {
        Collider[] hitColliders = Physics.OverlapSphere(attackingEntity.transform.position, 10);

        Transform nearest = null;
        float nearDist = float.PositiveInfinity;
        for (int i = 0; i < hitColliders.Length; i++)
        {
            Vector3 offset = attackingEntity.transform.position - hitColliders[i].transform.position;
            float thisDist = offset.sqrMagnitude;
            if (thisDist < nearDist)
            {
                nearDist = thisDist;
                nearest = hitColliders[i].transform;
            }
        }

        if (nearest != null)
        {
            return nearest.gameObject;
        }

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

    private Entity findFurthestTarget(Vector3 worldPosition)
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
