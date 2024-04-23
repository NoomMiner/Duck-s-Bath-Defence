using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementTiles : MonoBehaviour
{
    private CustomGrid<bool> tileAvailability;
    private int gridWidth = 21;
    private int gridHeight = 15;
    private float gridCellSize = 1f;
    // Start is called before the first frame update
    void Start()
    {
        tileAvailability = new CustomGrid<bool>(21, 15, 1f, new Vector3(-gridWidth * gridCellSize / 2, -gridHeight * gridCellSize / 2), () => true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
