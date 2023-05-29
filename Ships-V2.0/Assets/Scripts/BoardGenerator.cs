using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    public GameObject tile;
    private GameObject[][] playerBoard;
    private GameObject[][] enemyBoard;
    public float x = -7;
    public float y = 3.5f;
    
    private void Start()
    {
        for (int i = 0; i > 10; i++)
        {
            GameObject spawnedTile = Instantiate (tile, new Vector2(x,y),Quaternion.identity);
            spawnedTile.name = $"Tile {x} {y}";
            

        }
    }
}
