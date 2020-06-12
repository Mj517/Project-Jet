using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform Player;
    public Vector3 enemy;
    public Quaternion enemyR;
    public Rigidbody2D rb;
    public float thrust = 8f;
    
    




    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("InactiveZone"))
        {
            Vector3 dir = Player.position - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + 270;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        }

        if (other.CompareTag("ActiveZone"))
        {
            transform.position += transform.up  * thrust * Time.deltaTime;
            
        }

    }

    // Update is called once per frame
    void Update()
    {
       


      




    }


}
