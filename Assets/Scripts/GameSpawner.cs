using UnityEngine;
public class GroundSpawner : MonoBehaviour
{
    public GameObject groundPrefab;
    public Transform player;
    private float nextSpawnZ = 0f;
    public float tileLength = 10f;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnGround();
        }
    }
    void Update()
    {
        if (player.position.z + 50f > nextSpawnZ)
        {
            SpawnGround();
        }
    }
    void SpawnGround()
    {
        Instantiate(
            groundPrefab,
            new Vector3(0, 0, nextSpawnZ),
            Quaternion.identity
        );
        nextSpawnZ += tileLength;
    }
}