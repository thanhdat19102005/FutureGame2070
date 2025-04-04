using UnityEngine.UI; // UI Canvas
using UnityEngine.UIElements;

using UnityEngine;

public class healEnemy : Enemy   
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float damageEnter = 2f;
    public float damageStay = 1f;
     public   GameObject   imagePlayer;
    public override void Start()
    {
        base.Start();
    }
    public override void Player(GameObject Object)
    {
        player = Object;

    }
    public    void  Image(GameObject    imagePlayer1) {
        imagePlayer = imagePlayer1; 
          
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr"))
        {
            player.GetComponent<Player>().TakeDame(damageEnter);

        }
    }
    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Playerr"))
        {
            player.GetComponent<Player>().TakeDame(damageStay);
        }
    }

    public  override void Die()
    {
        base.Die();
        if (imagePlayer != null)
        {
            if (currentHp < MaxHp) {
                float value = MaxHp - currentHp;
                Debug.Log(value );
                imagePlayer.GetComponent<UnityEngine.UI.Image>().fillAmount = ((currentHp / MaxHp )+ (value / MaxHp));
            }
             

        }

    }


   



}
