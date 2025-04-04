using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public    class Player : MonoBehaviour
{
    public GameObject gameManager;
    public float speedPlayer = 5f;
    public float MaxHp = 50f;
    public float currentHp;
    public GameObject image;
    public GameObject EnemySpawner;
    public GameObject mussic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = MaxHp;
    }

    // Update is called once per frame
    void Update() {
        Vector2 inputPlayer = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        GetComponent<Rigidbody2D>().linearVelocity = inputPlayer  * speedPlayer;
        
        if  (inputPlayer.x  <  0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
         


        } else  if  (inputPlayer .x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
          
       if (inputPlayer != Vector2.zero)
        {
            GetComponent<Animator>().SetBool("state", true);
            
        }
       else
        {
            GetComponent<Animator>().SetBool("state",  false );

        }
          

    }
    public void TakeDame(float damage)
    {
        currentHp -= damage;
        currentHp = Mathf.Max(currentHp, 0);
        UpdateHp();
        if (currentHp <= 0)
        {
            Die();

        }

    }
    public virtual     void Die()
    {
        Destroy(gameObject);
       
        EnemySpawner.SetActive(false);
     

            SceneManager.LoadScene("Fail");



    }
    public void UpdateHp()
    {
        if (image != null)
        {
            image.GetComponent<UnityEngine.UI.Image>().fillAmount = currentHp / MaxHp;


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
          if  (collision  .gameObject   .CompareTag   ("Coin")) {
               gameManager.GetComponent<GameManager>().addPoint();
            mussic.GetComponent<Mussic>().EnemySound();

               Destroy(collision.gameObject);
            
        }
       if   (collision.gameObject .CompareTag    ("Usb") )   {
            Destroy(collision.gameObject,0.1f);
                 SceneManager.LoadScene("Win");
            

        } 


    }

}
