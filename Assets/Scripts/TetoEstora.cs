using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine;

public class TetoEstora : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jogador"))
        {
            Destroy(collision.gameObject);
        }
    }
}
