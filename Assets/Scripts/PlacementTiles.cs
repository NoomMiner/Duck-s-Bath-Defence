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
        {0, 0},
    };

    // Start is called before the first frame update
    void Start()
    {
        tileAvailability = new CustomGrid<bool>(21, 15, 1f, new Vector3(-gridWidth * gridCellSize / 2, -gridHeight * gridCellSize / 2), () => true);

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
