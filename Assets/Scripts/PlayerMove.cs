using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
     public float speed = 5.0f;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical"); 

        
        Vector3 movement = new Vector3(horizontal, vertical, 0.0f);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
