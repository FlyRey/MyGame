using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTarget : MonoBehaviour
{
    [SerializeField]
    private int _damage;

    [SerializeField]
    private GameObject enemy;

    void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
            Debug.Log("Обнаружен противник");
    }

    private void OnTriggerStay(Collider other)
    {      
        var player = other.GetComponent<Player>();
        if (player != null)
        {
            var relativePosition = player.transform.position - enemy.transform.position;
            var rotation = Quaternion.LookRotation(relativePosition);
            enemy.transform.rotation = rotation;
            var distance = Vector3.Distance(player.transform.position, transform.position);
            Debug.DrawRay(enemy.transform.position, transform.forward, Color.red);

            if (Physics.Raycast(enemy.transform.position, enemy.transform.forward, out var hitinfo, distance))
            {
                if (hitinfo.transform.GetComponent<Player>())
                {
                    player.Hit(_damage);
                    Debug.Log($"Попадание, нанесено {_damage} урона");
                }
                else
                {
                    Debug.Log("Нет Попадания"); 
                }
            }          
        }       
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Цель потеряна");
    }
}
