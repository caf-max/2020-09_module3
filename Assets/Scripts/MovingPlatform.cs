using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform[] points;
    public float speed;

    private float current;  // от 0 до 1
    private int dir;
    private int point;

    void Start()
    {
        current = 0.0f;
        dir = 1;
        point = 0;
    }

    void Update()
    {
        current += speed * Time.deltaTime;

        if (current > 1.0f)
        {
            point += dir;
            current = 0.0f;
        }

        if (point >= points.Length-1)
        {
            dir = -1;
        }
        else if (point <= 0)
        {
            dir = 1;
        }

        Transform start = points[point];
        Transform end = points[point + dir];

        transform.position = Vector3.Lerp(start.position, end.position, current);
    }
}

