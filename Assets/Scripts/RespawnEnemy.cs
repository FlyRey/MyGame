using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public Transform Respawn;
    
   


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            Create();
    }

    public void Create()
    {
        
        Instantiate(Enemy, Respawn);

    }
}
