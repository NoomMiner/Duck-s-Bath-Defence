using Codice.Client.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPointLeft;
    public Transform spawnPointRight;

   
    private float waveStartTimer = 2f;
    public float timeBetweenWaves = 10f;
    private int waveNumber = 1;


    // Update is called once per frame
    void Update()
    {
       // spawn rate = -(rate of change)time + (start rate)
       if (waveStartTimer <= 0)
        {
            StartCoroutine(spawnWave());
            waveNumber++;
            waveStartTimer = timeBetweenWaves;

        }

       waveStartTimer -= UnityEngine.Time.deltaTime;
    }

    IEnumerator spawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            if ( i % 2 == 0 )
            {
                enemyPrefab.gameObject.GetComponent<Enemy>().spawnsLeft = true;
                enemyPrefab.gameObject.GetComponent<Enemy>().gameManager = this.gameObject.GetComponent<GameManager>();
                Instantiate(enemyPrefab, spawnPointLeft.position, spawnPointLeft.rotation);
            }
            else
            {
                enemyPrefab.gameObject.GetComponent<Enemy>().spawnsLeft = false;
                enemyPrefab.gameObject.GetComponent<Enemy>().gameManager = this.gameObject.GetComponent<GameManager>();
                Instantiate (enemyPrefab, spawnPointRight.position, spawnPointRight.rotation);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

}
