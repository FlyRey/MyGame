using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyToMine : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    
    private void Update()
    {
        var mine = GameObject.FindGameObjectWithTag("Mine");
        var relativePosition = mine.transform.position - transform.position;
        var rotation = Quaternion.LookRotation(relativePosition);
        transform.position = Vector3.MoveTowards(transform.position, mine.transform.position, _speed * Time.deltaTime);
        transform.rotation = rotation;
    }
}
