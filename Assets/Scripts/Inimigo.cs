using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float speed = 5f;
    public float minY = 0f;
    public float maxY = 5f;

    private float targetY;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        targetY = maxY;
    }

    public int health_mob = 10;

    public void TakeDamage_mob(int damageAmount)
    {
        health_mob -= damageAmount;

        if (health_mob <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        // Move o inimigo verticalmente em direção ao targetY
        float y = Mathf.MoveTowards(transform.position.y, targetY, speed * Time.fixedDeltaTime);
        rb.MovePosition(new Vector3(transform.position.x, y, transform.position.z));

        // Altera o targetY quando o inimigo atinge a posição máxima ou mínima
        if (transform.position.y >= maxY || transform.position.y <= minY)
        {
            targetY = targetY == maxY ? minY : maxY;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tiro"))
        {
            Destroy(collision.gameObject);
        }
    }
}
