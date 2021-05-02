using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTarget : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    public GameObject enemy;

    void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("MainHero"))
        Debug.Log("Обнаружен противник");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainHero"))
        {
            var player = other.GetComponent<Player>();
            if (player != null)
            {
                var relativePosition = player.transform.position - enemy.transform.position;
                var rotation = Quaternion.LookRotation(relativePosition);
                enemy.transform.rotation = rotation;

                if (Physics.Raycast(enemy.transform.position, player.transform.position, out var hitinfo))
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
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Цель потеряна");
    }
}
