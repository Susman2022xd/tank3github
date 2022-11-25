using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcode : MonoBehaviour
{
    float mouseX = 10.3f;
    SpriteRenderer renderer;
    Rigidbody2D rigidbody;
    float speedBullet = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 mousePositionInUnity = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 korpusPosition = transform.position;
        Vector3 look = mousePositionInUnity - korpusPosition;
        look.z = 0;
        transform.right = look;
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();


        Vector3 move = Vector3.right * Input.GetAxis("Fire1");
        rigidbody.AddRelativeForce(move * speedBullet);


    }
}
