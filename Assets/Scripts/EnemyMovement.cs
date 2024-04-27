using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Enemy enemy;

    // SerializedField allows for the editing of private values in the inspector
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] private float rotationSpeed;

    private Transform target;
    private int pathIdxLeft = -1;
    private int pathIdxRight = 46;

    private void Start()
    {
        // Init to first point in path
        if ( enemy.spawnsLeft )
        {
            target = GameManager.main.startPointLeft;
        }
        else
        {
            target = GameManager.main.startPointRight;
        }
        
    }

    private void Update()
    {
        Vector2 direction = -(target.position - transform.position).normalized;

        if (Vector2.Distance(target.position, this.gameObject.transform.position) <= 0.1f)
        {
            if( isAtDrain() )
            {

                if ( pathIdxLeft == 24)
                {
                    pathIdxLeft = 21;

                    target = GameManager.main.path[pathIdxLeft];

                }
                else if ( pathIdxRight == 24)
                {
                    pathIdxRight = 21;

                    target = GameManager.main.path[pathIdxRight];
                }
                else
                {
                    pathIdxLeft++;
                    pathIdxRight++;
                    target = GameManager.main.path[pathIdxLeft];
                }
            }

            else
            {
                pathIdxLeft++;
                pathIdxRight--;

                if (enemy.spawnsLeft)
                {
                    target = GameManager.main.path[pathIdxLeft];
                }
                else
                {
                    target = GameManager.main.path[pathIdxRight];
                }
            }
        }

        Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        // moves game object
        Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * moveSpeed;

        
    }

    public bool isAtDrain()
    {
        if (pathIdxLeft >= 21 || (pathIdxRight <= 21 && pathIdxRight >= 24))
        {  
            return true; 
        }

        return false;
    }
}
