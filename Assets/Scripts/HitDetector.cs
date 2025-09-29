using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDirector : MonoBehaviour
{
       private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            EnemyController enemycontroller = other.GetComponent<EnemyController>();
            if(enemycontroller != null)
            {
                enemycontroller.GotHit();
            }

        }
    }

}
