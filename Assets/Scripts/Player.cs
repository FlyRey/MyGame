using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] 
    private int _health;

    private int _maxHealth = 200;
    public void Hit(int damage)
    {
        
        if (_health != 0)
        {
           _health -= damage;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int Healing (int healpoint)
    {
        int a;
        if (_health < _maxHealth)
        {
            if (_health + healpoint < _maxHealth)
            {
                _health += healpoint;
                a = 1;
            }
            else
            {
                _health = _maxHealth;
                a = 1;
            }
        }
        else
        {
            a = 0;
        }
        return a;
    }
}
