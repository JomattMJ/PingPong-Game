using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoint : MonoBehaviour
{
    public GameObject ball;
    public GameObject point;

    private void OnTriggerEnter(Collider other)
    {
        Score.instance.AddPoint();

        ball.transform.position = point.transform.position;
    }
}
