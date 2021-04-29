using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkMine : MonoBehaviour
{
    [SerializeField]
    private int _damage;

    private void Start()
    {
        Debug.Log("Нажмите H, что бы запустить демонстрацию бомбы");
    }
    void OnTriggerEnter(Collider collider)
    {
        
        if (collider.gameObject.CompareTag("Enemy"))
        {
            var enemy = collider.GetComponent<Enemy>();
            enemy.Hurt(_damage);
        }
            
    }
}
