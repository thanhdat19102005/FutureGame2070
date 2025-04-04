using Unity.Cinemachine;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
     
    public   Vector3 destinaton ;
    public Vector3 pos;
    public float moveSpeed = 5f;
    public float damage = 5f;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
       
    }

    // Update is called once per frame
    void Update()  {
        pos = (destinaton-transform.position) .normalized ;
        GetComponent<Rigidbody2D>().linearVelocity = pos * moveSpeed;
          
         
    }

    private void OnTriggerEnter2D(Collider2D collision) {
           if  (collision  .gameObject   .CompareTag  ("Enemy") ) {
           }
    }
     public void directionToPlayer(GameObject    playerPostion )  {
        if    (player !=  null)
             this . destinaton = playerPostion.transform.position;
            

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr")){
            GameObject enemy = collision.gameObject;
            enemy.GetComponent<Player>().TakeDame(2f);              



        }
    }
}
