using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    // attributes
    public String entityName;
    public AttackType attack;
    private float currentHealth;
    public float maxHealth;
    public float attackCooldown;
    public float damage;
    public float range;
    public TargetFamily family;
    public TargetFamily targetFamily;

    // private members
    private float lastAttackTime;

    // runtime functions
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void takeDamage(float amount)
    {

    }

    public void heal(float amount)
    {

    }

    public void die()
    {

    }
}

public enum TargetFamily
{
    Tower,
    Enemy,
    Drain,
    None
}