using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcode : MonoBehaviour
{
    float mouseX = 10.3f;
    SpriteRenderer renderer;
    Rigidbody2D rigidbody;
    float speedBullet = 5;
    public Vector3 look = Vector3.zero;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            




            


            if (Vector3.zero != look)
        {
            Vector3 move = look;
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.AddRelativeForce(move * 3);


        }


       


    }
}
