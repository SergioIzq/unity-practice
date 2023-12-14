using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Vector3 pointA = new Vector3(0.0F, 0.0F, 0.0F);
    public Vector3 pointB = new Vector3(10.0F, 0.0F, 10.0F);
    public float speed = 2.0F;

    private float startTime;
    private bool isMovingToPointB = true;

    void Update()
    {
        float journeyLength = Vector3.Distance(pointA, pointB);
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;

        if (isMovingToPointB)
        {
            transform.position = Vector3.Lerp(pointA, pointB, fracJourney);
        }
        else
        {
            transform.position = Vector3.Lerp(pointB, pointA, fracJourney);
        }

        if (fracJourney >= 1.0F)
        {
            isMovingToPointB = !isMovingToPointB;
            startTime = Time.time;
        }
    }
}

