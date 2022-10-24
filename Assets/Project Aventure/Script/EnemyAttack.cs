using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)    
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Attacked");
        }
    }
}
