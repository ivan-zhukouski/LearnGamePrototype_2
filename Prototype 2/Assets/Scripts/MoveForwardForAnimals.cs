using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardForAnimals : MonoBehaviour
{
    // Update is called once per frame
    public int speed;
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.S))
       {
         speed = Random.Range(2,10);
       }
       transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
