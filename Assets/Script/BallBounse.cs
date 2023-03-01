using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounse : MonoBehaviour
{
    public Vector3 BallForce;
    public new Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
       // rigidbody= GetComponent<Rigidbody>();
        rigidbody.AddForce(BallForce, ForceMode.Impulse);
    }

   
}
