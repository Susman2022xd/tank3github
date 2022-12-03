using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headcode : MonoBehaviour
{
    float timershoot = 0;
    float bordershoot = 1;

    bool fire = true;
    public GameObject shoot;
    public GameObject shootspawn;
    public GameObject bulletObj;
    float mouseX = 10.3f;
    SpriteRenderer renderer;
    Rigidbody2D rigidbody;
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

        
        if (Input.GetAxis("Fire1")==1 && fire){
            fire = false;

            GameObject shootanime = Instantiate(shoot, shootspawn.transform);
            GameObject bullet = Instantiate(bulletObj, shootspawn.transform.position, Quaternion.identity);
            bullet.GetComponent<bulletcode>().look = look;
            Destroy(shootanime, 0.25f);
            Destroy(bullet, 3);
            

        }
        else
        {
            timershoot += Time.deltaTime;
            if (timershoot >= bordershoot)
            {
                timershoot = 0;
                fire = true;
            }
        }
    }
}   
