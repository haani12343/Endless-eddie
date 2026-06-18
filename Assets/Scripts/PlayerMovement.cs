using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private AudioSource audioSource;
    public AudioClip jumpSound;
    public float speed = 5f;
    public float speedIncreaseRate = 0.1f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

    }
    void Update()
    {
        transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        speed += speedIncreaseRate * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space))
        {
           rb.AddForce(Vector3.up * 7f, ForceMode.Impulse);
           if (jumpSound != null)
           {
            audioSource.PlayOneShot(jumpSound);

           }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }

}