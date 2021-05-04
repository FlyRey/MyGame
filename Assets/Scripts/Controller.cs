using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public int SpeedRotation = 3;
    public int Speed = 5;
    public int JumpSpeed = 50;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * SpeedRotation);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * SpeedRotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += transform.up * JumpSpeed * Time.deltaTime;
        }
    }
}
