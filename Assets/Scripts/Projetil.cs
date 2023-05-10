using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
   public float speed = 10f; // Velocidade do projétil

    private void Update()
    {
        // Movimenta o projétil para a direita
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            Destroy(collision.gameObject); // Destroi o inimigo
            Destroy(gameObject); // Destroi o projétil
        }
    }
    


}
