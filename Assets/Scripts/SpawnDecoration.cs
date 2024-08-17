using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpawnDecoration : MonoBehaviour
{
    public int quantity;
    public int minX;
    public int maxX;
    public int minY;
    public int maxY;
    public int minZ;
    public int maxZ;
    public GameObject[] objects;
    private Tilemap tileMap;

    void Start()
    {
        tileMap = transform.parent.GetComponent<Tilemap>();
        for (int i = 1; i <= quantity; i++)
        {
            Spawn();
        }

    }

    public void Spawn()
    {
        countingRandom:
        Vector3Int position = new Vector3Int(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        if (tileMap.HasTile(position) == true)
        {
            int random = Random.Range(0, objects.Length - 1);
            Instantiate(objects[random], position, Quaternion.identity);
        }
        else { goto countingRandom; }
    }
    
}
