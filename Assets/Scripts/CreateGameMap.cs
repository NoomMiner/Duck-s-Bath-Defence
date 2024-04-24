using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class CreateGameMap : MonoBehaviour
{
    // Start is called before the first frame update

    private CustomGrid<bool> tileGrid;
    private int gridWidth = 21;
    private int gridHeight = 15;
    private float gridCellSize = 0.8f;

    void Start()
    {
        tileGrid = new CustomGrid<bool>(21, 15, 0.8f, new Vector3(-gridWidth * gridCellSize / 2, -gridHeight * gridCellSize / 2), () => false);
        tileGrid.SetValue(0, 7, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


