using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Vector2 pointA = new Vector2(0.0f, 0.0f);
    public Vector2 pointB = new Vector2(10.0f, 0.0f);
    public float speed = 2.0f;

    private float startTime;
    private bool isMovingToPointB = true;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float journeyLength = Vector2.Distance(pointA, pointB);
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;

        if (isMovingToPointB)
        {
            transform.position = Vector2.Lerp(pointA, pointB, fracJourney);
        }
        else
        {
            transform.position = Vector2.Lerp(pointB, pointA, fracJourney);
        }

        if (fracJourney >= 1.0f)
        {
            isMovingToPointB = !isMovingToPointB;
            startTime = Time.time;
        }
    }
}