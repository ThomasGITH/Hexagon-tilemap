using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilemap : MonoBehaviour
{
    public Vector2 position, size;

    void Start()
    {
        GameObject hexagon = GameObject.Find("Hexagon");
        
        for (int i = 0; i < size.y; i++)
        {
            for (int j = 0; j < size.x; j++)
            {
                Instantiate(hexagon, new Vector2(position.x + (i % 2 == 0 ? 0 : 0.75f) + (1.50f * j),
                    position.y + 0 - (0.52f * i)), transform.rotation);
            }
        }


    }
}
