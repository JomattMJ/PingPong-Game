using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerMovement : MonoBehaviour
{

    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        float horizontalinput = SimpleInput.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * horizontalinput * speed);
    }
}
