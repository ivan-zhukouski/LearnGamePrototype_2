using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour

{
    private float horizontalImput;
    private float verticalInput;
    private float mouseInputX;
    private float mouseInputY;
    public float speed  = 25f;
    public float xRange = 20f;
    public float zRange = 10f;
    public GameObject[] projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
   
    {
    
    horizontalImput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");
    mouseInputX = Input.GetAxis("Mouse X");
    mouseInputY = Input.GetAxis("Mouse Y");

    transform.Translate(Vector3.right * Time.deltaTime * horizontalImput * speed);  
    transform.Translate(Vector3.right * Time.deltaTime * mouseInputX * speed);

    transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed); 
    transform.Translate(Vector3.forward * Time.deltaTime * mouseInputY * speed); 

    if(transform.position.x < -xRange) 
    {
    transform.position = new Vector3( -xRange, transform.position.y, transform.position.z);
    }

    if(transform.position.x > xRange) 
    {
    transform.position = new Vector3( xRange, transform.position.y, transform.position.z);
    }
    if(transform.position.z > zRange) 
    {
    transform.position = new Vector3( transform.position.x, transform.position.y, zRange);
    }
    if(transform.position.z < 0) 
    {
    transform.position = new Vector3( transform.position.x, transform.position.y, 0);
    }

    //lounch projectile from player
    if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
    {
       int foodIndex = Random.Range(0, projectilePrefab.Length);
       Instantiate(projectilePrefab[foodIndex], transform.position, projectilePrefab[foodIndex].transform.rotation);
    }
 
    }
}
