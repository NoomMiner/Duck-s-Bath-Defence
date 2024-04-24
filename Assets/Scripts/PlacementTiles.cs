using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementTiles : MonoBehaviour
{
    private CustomGrid<bool> tileAvailability;
    private int gridWidth = 21;
    private int gridHeight = 15;
    private float gridCellSize = 1f;

    private int[,] enemyPath = new int[,] {
        {0,7},{1,7},{2,7},{2,8},{2,9},{3,9},{3,10},{4,10},{4,11},{4,12},{5,12},{5,13},{6,13},{7,13},{8,13},{9,13},{10,13},{11,13},{12,13},{13,13},{13,12},{14,12},{14,11},{15,11},{15,10},{15,9},{14,9},{14,8},{13,8},{13,7},{13,6},{13,5},{13,4},{12,4},{12,3},{11,3},{10,3},{9,3},{9,4},{9,5},{9,6},{10,6},{11,6},{11,7},{10,7},{9,7},{9,8},{10,8},{11,8},{11,9},{11,10},{10,10},{9,10},{8,10},{7,10},{7,9},{7,8},{6,8},{6,7},{5,7},{5,6},{5,5},{4,5},{4,4},{4,3},{5,3},{5,2},{6,2},{6,1},{7,1},{8,1},{9,1},{10,1},{11,1},{12,1},{13,1},{14,1},{14,2},{15,2},{15,3},{15,4},{15,5},{16,5},{16,6},{17,6},{17,7},{18,7},{19,7},{20,7}
    };

    // Start is called before the first frame update
    void Start()
    {
        tileAvailability = new CustomGrid<bool>(21, 15, 1f, new Vector3(-gridWidth * gridCellSize / 2, -gridHeight * gridCellSize / 2), () => true);

        Debug.Log(enemyPath.GetLength(0));
        // Disable enemy path
        for (int i = 0; i < enemyPath.GetLength(0); i++)
        {
            tileAvailability.SetValue(enemyPath[i, 0], enemyPath[i, 1], false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public CustomGrid<bool> getGrid()
    {
        return tileAvailability;
    }
}
