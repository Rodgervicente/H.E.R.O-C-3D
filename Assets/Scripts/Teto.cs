using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teto : MonoBehaviour
{
 private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jogador"))
        {
            // Carrega a próxima cena
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
