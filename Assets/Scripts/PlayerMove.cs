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
        Vector3 movement = Vector3.zero;
        if(SystemInfo.supportsAccelerometer) {
            movement = accelerometerMovement();
        } else {
           movement = wasdMovement();
        }
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    Vector3 accelerometerMovement() {
        float horizontal = Input.acceleration.x;
        float vertical = Input.acceleration.y;
        return new Vector3(horizontal, vertical, 0.0f);

    }

    Vector3 wasdMovement() {
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical"); 

        
        return new Vector3(horizontal, vertical, 0.0f);

        
    }
}
