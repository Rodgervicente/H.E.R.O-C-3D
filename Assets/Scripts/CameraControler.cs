using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Transform player;
   private Vector3 offset;
   // Start is called before the first frame update
   void Start()
   {
       offset = transform.position - player.position;
   }

   // Update is called once per frame
   void Update()
   {
             
   }

   private void LateUpdate() {
     transform.position = player.position + offset;
   }
}
