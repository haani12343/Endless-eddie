using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    void Start()
    {
     Debug.Log("Array Size: " + obstaclePrefabs.Length);

     for (int i = 0; i < obstaclePrefabs.Length; i++)
     {
         if (obstaclePrefabs[i] == null)
     {
         Debug.LogError("Element " + i + " is NULL!");
         }
      else
  {
     Debug.Log("Element " + i + " = " + obstaclePrefabs[i].name);
            }
        }

        InvokeRepeating(nameof(SpawnObstacle), 1f, 3f);
    }

    void SpawnObstacle()
    {
     int randomIndex = Random.Range(0, obstaclePrefabs.Length);

     if (obstaclePrefabs[randomIndex] == null)
    {
      Debug.LogError("Obstacle Prefab " + randomIndex + " is NULL!");
      return;
     }

    Instantiate(
     obstaclePrefabs[randomIndex],
      transform.position,
  Quaternion.identity
  );
 }
}