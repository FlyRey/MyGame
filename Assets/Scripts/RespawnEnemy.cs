using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemy;
    [SerializeField]
    private Transform _respawn;
    

   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            Create();
    }

    private void Create()
    {
        
        Instantiate(_enemy, _respawn);

    }
}
