using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endFase : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jogador"))
        {
            // Reinicia a cena atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}