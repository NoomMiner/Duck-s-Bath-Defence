using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Enemy enemy;

    // SerializedField allows for the editing of private values in the inspector
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2.0f;

    private Transform target;
    private int pathIdx = 0;

    private void Start()
    {
        // Init to first point in path
        target = GameManager.main.pathLeft[0];
    }

    private void Update()
    {

        if (Vector2.Distance(target.position, transform.position) <= 0.1f )
        {
            
            if (pathIdx <= 25)
            {
                pathIdx++;
            }
            else
            {
                pathIdx = 22;
            }

            target = GameManager.main.pathLeft[pathIdx];

        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * moveSpeed;
    }

}
