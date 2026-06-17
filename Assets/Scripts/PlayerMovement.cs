using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
private Rigidbody rb;

 void Start()
    {
        rb = GetComponent<Rigidbody>();
  }

 void Update()
{
        transform.position += new Vector3(0, 0, 5) * Time.deltaTime;

  if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 7f, ForceMode.Impulse);  }
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