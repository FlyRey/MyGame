using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineKit : MonoBehaviour
{
    [SerializeField]
    private int _healpoint = 100;

    [SerializeField]
    private float _rotationSpeed = 40f;

    private void Update()
    {
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        int a;
        if (other.CompareTag("MainHero"))
        {
            var player = other.GetComponent<Player>();
            if(player != null)
            {
              a = player.Healing(_healpoint);
                if(a != 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
