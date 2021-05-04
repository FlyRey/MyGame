using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int _health;

    public void Hurt(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("BOOOOM");
        }
    }

}
