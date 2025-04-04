using TMPro;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed  = 10f;
    public float existBullet = 1;
    public  float damage = 10f;
    public GameObject blood;
    public  float   damageBoss = 2f;
    public GameObject mussic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
       
        if (mussic != null)
        {
            mussic.GetComponent<Mussic>().PlayeshootSound();
        }
        else
        {
           
        }
    }

    // Update is called once per frame
    void Update()
    {

             
        transform.Translate(Time.deltaTime * bulletSpeed, 0, 0);
        //      thởi  gian  tồn  tại    gameObjectt
        if (existBullet == 1) {
            Destroy(gameObject, 2f);
            existBullet++;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if  (collision .gameObject.CompareTag("Enemy"))  {
            GameObject enemy = GameObject.Find(collision.gameObject.name);
          

            if  (enemy  !=   null   &&   enemy .name .Equals   ("EnemyNomal(Clone)") ){
                
                enemy.GetComponent<EnemyNomal>().TakeDame( damage);
               GameObject bl    =  Instantiate(blood, transform.position, Quaternion.identity);
                Destroy(bl, 0.5f);

            }
            else   if    (enemy != null && enemy.name.Equals("EnergyEnemy") || enemy.name.Equals("EnergyEnemy1") || enemy.name.Equals("EnergyEnemy2")  || enemy.name.Equals("EnergyEnemy(Clone)"))   {
                enemy.GetComponent<EnergyEnemy>().TakeDame(damage);
                GameObject bl =    Instantiate(blood, transform.position, Quaternion.identity);
                Destroy(bl, 0.5f);
            }

            else   if   (enemy   !=  null      &&  enemy .name .Equals   ("HealEnemy(Clone)")  )
            {
                enemy.GetComponent<healEnemy>().TakeDame(damage);
               GameObject bl=   Instantiate(blood, transform.position, Quaternion.identity);
              Destroy(bl, 0.5f);

            }
            else   if   (enemy  !=   null    && enemy.name.Equals("ExplosionEnemy(Clone)"))
            {
              enemy.GetComponent<ExplosionEnemy>().TakeDame(damage);
              GameObject   bl  =      Instantiate(blood, transform.position, Quaternion.identity);
               Destroy(bl, 0.5f);

            }else   if    (enemy  !=  null   &&   enemy.name   .Equals    ("BossEnemy")  )
            {
                GameObject bl = Instantiate(blood, transform.position, Quaternion.identity);
                Destroy(bl, 0.5f);
                enemy.GetComponent<Boss>().TakeDame(1);
                
             }
           
            else   if   (enemy != null && enemy.name.Equals("MiniEnemy(Clone)"))  {
                GameObject bl = Instantiate(blood, transform.position, Quaternion.identity);
                Destroy(bl, 0.5f);
                enemy.GetComponent<DogEnemy>().TakeDame(damageBoss);
            }
            // thu   
           

            Destroy(gameObject);
             

        }

    }

    public void Mussic(GameObject mus)
    {
        mussic = mus;
    }  
}
