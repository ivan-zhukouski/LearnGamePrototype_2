using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   
   void OnTriggerEnter(Collider other) {
       ScoreScript.scoreValue +=1;
       Destroy(gameObject);
       Destroy(other.gameObject);

   }
    void Update() 
    {
     
   }
}
