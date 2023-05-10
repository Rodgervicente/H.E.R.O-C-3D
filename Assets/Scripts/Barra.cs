using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Slider slider;

    private float currentValue;

    private void Start()
    {
        currentValue = slider.value;
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        transform.position += movement * moveSpeed * Time.deltaTime;

        // Diminui o valor do Slider com base na distância percorrida pelo jogador
     
}
}
