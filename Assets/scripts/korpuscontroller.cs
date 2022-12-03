using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class korpuscontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody;

    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 move = ver * Vector3.right;
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddRelativeForce(move * 3);
        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z - hor / 2);
    }
}
