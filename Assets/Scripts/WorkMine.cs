using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkMine : MonoBehaviour
{
    [SerializeField]
    private int _damage;

    private void Start()
    {
        Debug.Log("������� H, ��� �� ��������� ������������ �����");
    }
    void OnTriggerEnter(Collider collider)
    {
        var enemy = collider.GetComponent<Enemy>();
        if (enemy != null)
        {
           enemy.Hurt(_damage);
        }
            
    }
}
