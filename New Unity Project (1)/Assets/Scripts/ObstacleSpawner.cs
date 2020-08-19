using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float minY;
    public float maxY;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            float obstacleY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(transform.position.x + distance, obstacleY, 0);
            collision.gameObject.transform.position = spawnPosition;
        }
        
    }
}
