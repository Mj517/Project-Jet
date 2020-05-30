using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalSpeed = 3f;
    public float verticalSpeed = 2f;
    public GameObject Bullet;
    public Transform firePoint;
    public float bulletForce = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 2, 0) * verticalSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-2, 0, 0) * horizontalSpeed * Time.fixedDeltaTime);
        }
       
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -2, 0) * verticalSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(2, 0, 0) * horizontalSpeed * Time.fixedDeltaTime);
            
        }
        

        
    }

    void Shoot()
    {
        Debug.Log("Fire!");
        GameObject bullet = Instantiate(Bullet, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        
    }
}
