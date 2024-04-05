using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    // attributes
    public String entityName;
    private float currentHealth;
    public float maxHealth;
    public float attackCooldown;
    public float damage;
    public float range;
    public TargetFamily family;
    public TargetFamily targetFamily;
    private AttackType attack;

    // misc.
    private float lastAttackTime;

    // runtime functions
    void Start()
    {
       currentHealth = maxHealth;
       lastAttackTime = 0;
       setAttackType(new SingleClosestTarget());
    }

    void Update()
    {
        if (Time.time - lastAttackTime > attackCooldown)
        {
            attack.attack(this);
            lastAttackTime = Time.time;
        }
    }

    public float getCurrentHealth()
    {
        return currentHealth;
    }

    public void setAttackType(AttackType newAttack)
    {
        attack = newAttack;
    }

    public void takeDamage(float amount)
    {
        float newHealth = currentHealth - amount;

        if (newHealth <= 0)
        {
            currentHealth = 0;
            die();
        }
        else
        {
            currentHealth = newHealth;
        }
    }

    public void heal(float amount)
    {
        float newHealth = currentHealth + amount;

        if (newHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth = newHealth;
        }
    }

    public virtual void die()
    {
        Destroy(this.gameObject);
    }
}

public enum TargetFamily
{
    Tower,
    Enemy,
    Drain,
    None
}