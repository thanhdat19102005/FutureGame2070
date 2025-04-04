using System.Collections;

using UnityEngine;

public class Boss : Enemy  
{
    public GameObject Image;
    public float damageEnter = 2f;
    public float damageStay = 0.5f;
    public GameObject danThuong;
    public GameObject dogEnemy;
    public float thoiGianCho = 3f;
    public float nextTime = 0f;
    public GameObject usb;
    public GameObject mussic;
    //   lay  tham chieu  ben  hierachy  
    public GameObject mainPlayer;
           
    public override void Start()  {
        base.Start();
        //   goi  function    tao  vien dan thuong 
        mussic.GetComponent<Mussic>().BossSound();


     }
    public override void Update(){
        base.Update();
        if (Time.time >=   nextTime) {
            SetTime();
            
        }
          
    }
    //     goi    tạo  đạn   thường    
    public    IEnumerator     call    (){

         yield return new WaitForSeconds(2f);
          GameObject buleet = Instantiate(danThuong, transform.position, Quaternion.identity);
          if   (mainPlayer != null) 
          buleet.GetComponent<BossBullet>().directionToPlayer(mainPlayer);
          Destroy(buleet, 1f);
     }
    //    gọi  và      dịch    chuyển     
          public IEnumerator call1 () {
         
            yield return new WaitForSeconds(2f);
               if (player != null) {
                float x = player.transform.position.x - 2;
                float y = player.transform.position.y - 2;
                float z = player.transform.position.z - 2;
                transform.position = new Vector3(x, y, z);
               
              
        }



    }
    //   tao  dogEnnemy  
    public IEnumerator call2() {
        
            yield return new WaitForSeconds(10f);
            GameObject   dogEnemyy = Instantiate(dogEnemy, transform.position -  new Vector3  (2,2,2), Quaternion.identity);
            dogEnemyy.GetComponent<DogEnemy>().Player  (player) ;
            dogEnemyy.GetComponent<DogEnemy>().Speed   (4f) ;

        
                
    }
      //   random   function
    public void Random(){
        int random = UnityEngine.Random.Range(1, 4);
        switch (random) {
            case 1:
                StartCoroutine(call());
                break;
            case 2:
                StartCoroutine(call1());
                 break;
            case 3:
                StartCoroutine(call2());
                break;
          }

         
    }
    //  set thoi   gion  
  public   void  SetTime  (){
        nextTime = Time.time   +   thoiGianCho;
        Random();

    }


    public override void Player(GameObject Object)
    {
        player = Object;

    }

    public  void   Imagee(GameObject    imagee )
    {
        
        Image = imagee;
         
    }
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr"))
        {
            player.GetComponent<Player>().TakeDame(damageEnter);

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr"))
        {
            player.GetComponent<Player>().TakeDame(damageStay);
        }
    }
    public override void Die()
    {
        base.Die();
        Instantiate(usb, transform.position,  Quaternion   .identity);
        mussic.GetComponent<Mussic>().Stop();


    }


}
