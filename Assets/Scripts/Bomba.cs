using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public float explosionRadius = 5f;
    public int damage = 100;
    public float delay = 3f;

    private void Start()
    {
        Invoke("Explode", delay);
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider collider in colliders)
        {
            Paredeestora parede = collider.GetComponent<Paredeestora>();

            if (parede != null)
            {
               parede .TakeDamage(damage);
            }
        }

        Destroy(gameObject);
    }

}
