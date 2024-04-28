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
    public bool canAttack;
    public TargetFamily family;
    public TargetFamily targetFamily;
    public GameObject healthBarPrefab;
    private AttackType attack;
    public bool isCollidable;
    public CircleCollider2D circleCollider;

    // misc.
    private float lastAttackTime;
    public GameManager gameManager;

    // runtime functions
    void Start()
    {
       currentHealth = maxHealth;
       lastAttackTime = 0;
       setAttackType(new SingleClosestTarget());
       canAttack = true;
       isCollidable = true;
    

       if (healthBarPrefab != null)
       {
            GameObject healthBar = Instantiate(healthBarPrefab);
            HealthBar healthBarScript;

            if (healthBar.TryGetComponent<HealthBar>(out healthBarScript))
            {
                healthBarScript.trackedEntity = this;
            }
       }

       GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");

       if (gameManagerObject != null)
       {
            gameManager = gameManagerObject.GetComponent<GameManager>();
       }
    }

    void Update()
    {
        
        if (Time.time - lastAttackTime > attackCooldown && canAttack)
        {
            attack.attack(this);
            lastAttackTime = Time.time;
        }

    }

    

    public float getCurrentHealth()
    {
        return currentHealth;
    }

    public void setCollidable(bool isCollidable)
    {
        this.isCollidable = isCollidable;
        this.circleCollider.enabled = isCollidable;
    }

    public void setCanAttack(bool canAttack)
    {
        this.canAttack = canAttack;
    }
    

    public void setAttackType(AttackType newAttack)
    {
        attack = newAttack;
    }

    public AttackType getAttackType()
    {
        return attack;
    }

    public void setHealth(float newHealth)
    {
        if (newHealth <= 0)
        {
            currentHealth = 0;
            die();
        }
        else if (newHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth = newHealth;
        }
    }

    public void takeDamage(float amount)
    {
        //Debug.Log(this.gameObject.name + " took " + amount + " damage");
        setHealth(currentHealth - amount);
    }

    public void heal(float amount)
    {
        setHealth(currentHealth + amount);
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