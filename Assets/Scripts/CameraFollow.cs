using UnityEngine;
using System.Collections;
public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 shakeOffset = Vector3.zero;
    private Coroutine shakeRoutine;
    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + new Vector3(0, 4, -8) + shakeOffset;
        }
    }
    public void Shake(float duration, float magnitude)
    {
        Debug.Log("SHAKE STARTED");
        if (shakeRoutine != null)
        {
            StopCoroutine(shakeRoutine);
        }
        shakeRoutine = StartCoroutine(ShakeCoroutine(duration, magnitude));
    }
    IEnumerator ShakeCoroutine(float duration, float magnitude)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            shakeOffset = new Vector3(
                Random.Range(-magnitude, magnitude),
                Random.Range(-magnitude, magnitude),
                0f
            );
            elapsed += Time.unscaledDeltaTime;
            yield return null;
        }
        shakeOffset = Vector3.zero;
    }
}