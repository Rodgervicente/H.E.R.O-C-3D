using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredeestora : MonoBehaviour
{
    public int health = 10;

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
