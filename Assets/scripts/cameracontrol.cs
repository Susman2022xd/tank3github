using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public GameObject korpus;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 korpusPosition = korpus.transform.position;
        korpusPosition.z = -10;

        transform.position = Vector3.Lerp(transform.position, korpusPosition, speed);

    }
}
