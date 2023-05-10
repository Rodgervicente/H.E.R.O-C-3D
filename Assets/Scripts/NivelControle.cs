using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelControle : MonoBehaviour
{
  
public int totaldeinimigo;
private int inimigosEliminado;

public Text textoPontos;
public Text textoTotal;
public GameObject textoFinal;

    void Start()
    {
 
    }

 public void SetInimigoseliminado()
 {
    inimigosEliminado++;

     textoPontos.text = "Pontos 0" + inimigosEliminado.ToString();

     if (inimigosEliminado >= totaldeinimigo) {textoFinal.SetActive(true);}
     
     
 }


    // Update is called once per frame
    void Update()
    {
      
    }

    

    
}
