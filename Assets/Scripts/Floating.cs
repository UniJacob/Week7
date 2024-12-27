using UnityEngine;

public class Floating : MonoBehaviour
{
    //[SerializeField] float FloatAmount = 5;
    //[SerializeField] float LerpSpeed = 0.01f;
    //[SerializeField] float MaxSpeed = 0.5f;
    //[SerializeField] float LerpMargin = 0;
    //float maxY, minY;
    //bool up = true;
    //void Start()
    //{
    //    maxY = transform.position.y + FloatAmount;
    //    minY = transform.position.y - FloatAmount;
    //}

    //void Update()
    //{
    //    var newPos = transform.position;
    //    if (up)
    //    {
    //        newPos.y = maxY;
    //    }
    //    else
    //    {
    //        newPos.y = minY;
    //    }
    //    transform.position = Vector3.Lerp(transform.position, newPos, Mathf.Min(LerpSpeed, MaxSpeed) * Time.deltaTime);
    //    Vector3.
    //    if (Vector3.Distance(transform.position, newPos) < LerpMargin)
    //    {
    //        up = !up;
    //    }
    //}

    [SerializeField] float horizontalRange = 5;
    float startY;

    void Start()
    {
        startY = transform.position.y;
    }
    void Update()
    {
        float newY = startY + horizontalRange * Mathf.Sin(Time.time);
        transform.position = new(transform.position.x, newY, transform.position.z);
    }
}
