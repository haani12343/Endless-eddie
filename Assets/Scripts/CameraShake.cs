using UnityEngine;
using System.Collections;
public class CameraShake : MonoBehaviour
{
    public static CameraShake instance;
    private Coroutine shakeCoroutine;
    void Awake()
    {
        instance = this;
    }
    public void Shake(float duration, float magnitude)
    {
        if (shakeCoroutine != null)
        {
            StopCoroutine(shakeCoroutine);
        }
        shakeCoroutine = StartCoroutine(ShakeRoutine(duration, magnitude));
    }
    IEnumerator ShakeRoutine(float duration, float magnitude)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            Vector3 randomOffset = new Vector3(
                Random.Range(-1f, 1f) * magnitude,
                Random.Range(-1f, 1f) * magnitude,
                0f
            );
            transform.position += randomOffset;
            yield return null;
            transform.position -= randomOffset;
            elapsed += Time.unscaledDeltaTime;
        }
    }
}