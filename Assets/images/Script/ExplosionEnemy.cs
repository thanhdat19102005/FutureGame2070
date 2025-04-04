using UnityEngine;

public class ExplosionEnemy : Enemy
{
    public float damageEnter = 2f;
    public float damageStay = 1f;
   public GameObject Explosion;
    //   thu  
    public GameObject Hp;


    public override void Start()
    {
        base.Start();






    }
    public override void Player(GameObject Object)
    {
        player = Object;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr"))
        {
            CreEx();
        }
    }

    public override void Die()
    {
        base.Die();
        CreEx();



    }
    //  create     a   Explosion   
    public void  CreEx   ()
    {
        Instantiate(Explosion, gameObject.transform.position, Quaternion.identity);
    }
   
}  
