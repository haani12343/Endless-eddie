using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
public GameObject obstaclePrefab;

void Start()
{
InvokeRepeating(nameof(SpawnObstacle), 0f, 4f);
 }
 void SpawnObstacle()
{     Debug.Log("Spawned at: " + Time.time);
        Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }
}