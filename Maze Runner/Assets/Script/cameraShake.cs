using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    [SerializeField] public bool start = false;
    public float duration = .5f;

    public void Update()
    {
        startShake();
    }

    public void startShake()
    {
        if (start)
        {
            start = false;
            StartCoroutine(shaking());
        }
    }
    IEnumerator shaking()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            transform.position = startPosition + Random.insideUnitSphere;
            yield return null;
        }
        transform.position = startPosition;
    }
}
