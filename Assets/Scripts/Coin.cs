using UnityEngine;
public class Coin : MonoBehaviour
{
    public AudioClip coinSound;
    private void Start()
    {
        if (coinSound == null)
        {
            coinSound = Resources.Load<AudioClip>("coin");

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager.coins++;
            if (coinSound != null)
            {
                AudioSource.PlayClipAtPoint(coinSound, transform.position);

            }
            Destroy(gameObject);
        }
    }
}