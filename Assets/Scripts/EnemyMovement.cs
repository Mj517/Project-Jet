using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform Player;
    public Vector3 enemy;
    public Quaternion enemyR;
    public Rigidbody2D rb;
    public float thrust = 1f;
    
    




    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("InactiveZone"))
        {
            transform.LookAt(Player);

        }

        if (other.CompareTag("ActiveZone"))
        {
            transform.position += transform.forward * thrust * Time.deltaTime;
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        enemy = transform.position;
        enemy.z = 0;
        transform.position = enemy;
        enemyR = transform.rotation;
        enemyR = new Quaternion(0, 0, 0, 0);
        transform.rotation = enemyR;


      




    }


}
