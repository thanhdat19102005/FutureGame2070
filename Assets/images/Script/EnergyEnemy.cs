
using UnityEngine;

public class EnergyEnemy :   Enemy 
{
    public float damageEnter = 2f;
    public float damageStay = 1f;
    public GameObject energyCoin;
    public GameObject mussic;

    public override void Start()
    {
        base.Start();


    }
    public override void Player(GameObject Object)
    {
        player = Object;

    }
    private void OnTriggerEnter2D(Collider2D collision){
             if   (collision  .gameObject   .CompareTag("Playerr")) {
            player.GetComponent<Player>().TakeDame(damageEnter);
             
        } 
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
           if   (collision  .gameObject    .CompareTag  ("Playerr") )
        {
            player.GetComponent<Player>().TakeDame(damageStay);
        }
    }
    public override void Die()
    {
        base.Die();


       if (energyCoin != null) {
          GameObject  coin   =      Instantiate(energyCoin ,  transform  .position  ,    Quaternion.identity);
            Destroy(coin, 7f);
            
        }
    }
    public   void    MussicEnergy  (GameObject mus)
    {
        mussic = mus;

    }

}
