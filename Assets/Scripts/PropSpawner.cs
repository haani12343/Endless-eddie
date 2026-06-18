using UnityEngine;
public class PropSpawner : MonoBehaviour
{
    public GameObject[] props;
    public Transform player;
    void Start()
    {
        InvokeRepeating(nameof(SpawnProps), 1f, 0.5f);

    }
    void SpawnProps()
    {
        int amount = Random.Range(2, 6);
        for (int i = 0; i < amount; i++)
        {
            float xPos = Random.Range(-18f, 18f);
            if (xPos > -4f && xPos < 4f)
            {
                xPos += xPos > 0 ? 6f : -6f;

            }
            Vector3 spawnPosition = new Vector3(
                xPos,
                0f,
                player.position.z + Random.Range(40f, 70f)
            );
            int randomProp =Random.Range(0, props.Length);
            Instantiate(
                props[randomProp],
                spawnPosition,
                Quaternion.Euler(0f, Random.Range(0f , 360f), 0f)
            );
        }
    }
}