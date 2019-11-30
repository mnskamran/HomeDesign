using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 20.0f;
    public float rotationSpeed = 100.0f;
    public float jumpHeight = 10f;


    private void FixedUpdate()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jumpHeight);
        }
    }
}
