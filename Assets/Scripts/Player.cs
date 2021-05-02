using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] 
    private int _health;

    public void Hit(int _damage)
    {
        
        if (_health != 0)
        {
           _health -= _damage;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
