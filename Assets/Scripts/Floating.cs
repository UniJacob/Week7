using UnityEngine;

public class Floating : MonoBehaviour
{
    [SerializeField] float horizontalRange = 5;
    float startY, randomStart;

    void Start()
    {
        startY = transform.position.y;
        randomStart = Random.Range(0, 360);
    }
    void Update()
    {
        float newY = startY + horizontalRange * Mathf.Sin(randomStart + Time.time);
        transform.position = new(transform.position.x, newY, transform.position.z);
    }
}
