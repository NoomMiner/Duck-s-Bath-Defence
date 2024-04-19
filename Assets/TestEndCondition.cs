using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestEndCondition : MonoBehaviour
{
    private Tower drain;
    private float last = 0;
    private float cooldown = 2;

    // Start is called before the first frame update
    void Start()
    {
        drain = GameObject.FindGameObjectWithTag("Tower").GetComponent<Tower>();
    }

    // Update is called once per frame
    void Update()
    {
        if (drain != null && Time.time - last >= cooldown)
        {
            drain.takeDamage(drain.maxHealth);
            last = Time.time;
        }
    }
}
