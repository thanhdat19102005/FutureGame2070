using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI; // UI Canvas
using UnityEngine.UIElements; 
public  abstract   class Enemy : MonoBehaviour{
    public GameObject player;
    public float speedEnemy = 0.2f;
    public float MaxHp = 50f;
    public float currentHp;
    public GameObject image;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public    virtual  void Start()  {
        currentHp = MaxHp;
    
    }
    public   virtual    void     Player   (GameObject    Object) {
          
    }

    // Update is called once per frame
      public virtual  void Update()
    {
        moveToPlayer();
      
    }
      //  di  chuyên  nhân  vật
    public    void    moveToPlayer  () {
           if  (player   !=  null){
            transform.position = Vector3 .MoveTowards(transform.position, player.transform.position, speedEnemy * Time.deltaTime);

             }

       Director();
    }
     //    tạo  hướng   xoay   cho    nhân   vật 
        public void Director() {
        if (player != null)
        {
            if (player.transform.position.x > transform.position.x)
            {
                GetComponent<SpriteRenderer>().flipX = false;

            }
            else if (player.transform.position.x < transform.position.x)
            {
                GetComponent<SpriteRenderer>().flipX = true;

            }
        }  
        
    }
     //   lấy    damage của   enemy  
 
    public     virtual    void TakeDame(float damage )
    {
        currentHp -= damage;
        currentHp = Mathf.Max(currentHp, 0);
        UpdateHp();
        if  (currentHp  <= 0)
        {
            Die();
             
        }  

    }
    //   Die   enemy  
    public    virtual    void Die()  {
        Destroy(gameObject);


    }
    public   virtual    void   UpdateHp   () {
           if (image != null) {
            image.GetComponent<UnityEngine.UI.Image>().fillAmount = currentHp / MaxHp;


        }
    }

}
