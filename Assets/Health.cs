using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int enemyHealth = 100;

    public void Damage(int damagePershot)
    {
        enemyHealth -= damagePershot;

        if (enemyHealth <= 0)
            RemoveEnemy();
    }

    void RemoveEnemy()
    {
        Destroy(gameObject);
    }
}
