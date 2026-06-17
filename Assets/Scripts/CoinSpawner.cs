using UnityEngine;
public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform player;

    void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 2f, 3f);
    }
    void SpawnCoin()
    {
        Vector3 spawnPosition = new Vector3(
            0f,
            1f,
            player.position.z + 20f
        );
        Instantiate(
    coinPrefab,
     spawnPosition,
     Quaternion.identity
        );
    }
}