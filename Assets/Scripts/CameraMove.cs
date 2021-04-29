using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    public float speedCam = 15;
    public float speedScroll = 15;
    public float minDistance;
    public float maxDistance;

    private bool _isActive = false;
    private float _distance;
    private float _x;
    private float _y;


    void LateUpdate()
    {
        _x = Input.GetAxis("Mouse X") * speedCam * 10;
        _y = Input.GetAxis("Mouse Y") * -speedCam * 10;

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
            if(Input.GetAxis("Mouse ScrollWheel") > 0 && _distance > minDistance)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speedScroll);
            }

            if(Input.GetAxis("Mouse ScrollWheel") < 0 && _distance < maxDistance)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * -speedScroll);
            }
        }
    }
}
