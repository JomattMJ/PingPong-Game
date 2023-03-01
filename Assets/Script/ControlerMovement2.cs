using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerMovement2 : MonoBehaviour
{
    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        float horizontalinput = SimpleInput.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * horizontalinput * speed);
    }
}
