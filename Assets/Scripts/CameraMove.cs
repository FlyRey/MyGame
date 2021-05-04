using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    public float SpeedCam = 15;
    public float SpeedScroll = 15;
    public float MinDistance;
    public float MaxDistance;

    private bool _isActive;
    private float _distance;
    private float _x;
    private float _y;


    void LateUpdate()
    {
        _x = Input.GetAxis("Mouse X") * SpeedCam * 10;
        _y = Input.GetAxis("Mouse Y") * -SpeedCam * 10;

        if (Input.GetMouseButtonDown(1))
        {
            _isActive = true;
        }

        if (Input.GetMouseButtonUp(1))
        {
            _isActive = false;
        }

        if (_isActive)
        {
            transform.RotateAround(player.transform.position, transform.up, _x * Time.deltaTime);
            transform.RotateAround(player.transform.position, transform.right, _y * Time.deltaTime);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        }

        if(Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            _distance = Vector3.Distance(transform.position, player.transform.position);
            if(Input.GetAxis("Mouse ScrollWheel") > 0 && _distance > MinDistance)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * SpeedScroll);
            }

            if(Input.GetAxis("Mouse ScrollWheel") < 0 && _distance < MaxDistance)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * -SpeedScroll);
            }
        }
    }
}
