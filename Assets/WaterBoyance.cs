using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBoyance : MonoBehaviour
{
    [SerializeField]
    float height = 0.1f;

    [SerializeField]
    float period = 1;

    private Vector3 cachePosition;
    private float offset;

    private void Awake()
    {
        cachePosition = transform.position;

        offset = 1 - (Random.value * 2);
    }

    private void Update()
    {
        transform.position = cachePosition - Vector3.up * Mathf.Sin((Time.time + offset) * period) * height;
    }
}
