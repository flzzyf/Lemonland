using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public int row, col;

    public GameObject[] floorTiles;

    public float height = 286;

	void Start () {
		
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                GameObject instance = Instantiate(floorTiles[Random.Range(0, floorTiles.Length)], new Vector3(i * height, j * height, 0), Quaternion.identity) as GameObject;
            }
        }
	}
	
}
