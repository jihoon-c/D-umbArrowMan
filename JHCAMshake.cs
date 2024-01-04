using System.Collections;
using UnityEngine;

public class JHCAMshake : MonoBehaviour
{
    private float shakeTime;
    private float shakeIntensity;


    public void Start()
    {
        OnShakeCamera(3f, 1.5f);
    }

    private void Update()
    {
        
    }

    public void OnShakeCamera(float shakeTime=1.0f,float shakeIntensity = 0.1f)
    {
        this.shakeTime = shakeTime;
        this.shakeIntensity = shakeIntensity;

        StopCoroutine("ShakeByposition");
        StartCoroutine("ShakeByPosition");
    }

    public IEnumerator ShakeByPosition()
    {
        Vector3 startPosition = transform.position;

        while (shakeTime > 0.0f)
        {
            transform.position = startPosition + Random.insideUnitSphere * shakeIntensity;

            shakeTime -= Time.deltaTime;

            yield return null;
        }
        transform.position = startPosition;
    }
}
