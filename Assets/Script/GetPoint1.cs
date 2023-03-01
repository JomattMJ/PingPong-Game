using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoint1 : MonoBehaviour
{
    public GameObject ball;
    public GameObject point;
    private void OnTriggerEnter(Collider other)
    {
        Score1.instance.AddPoint();

        ball.transform.position = point.transform.position;
    }
}
