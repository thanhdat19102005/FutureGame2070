using UnityEngine;

public class DogEnemy :   Enemy
{
    public float damageEnter = 2f;
    public float damageStay = 1f;
  public override void Start(){
        base.Start();
}
    public override void Player(GameObject Object){
        player = Object;
    }
    public   void  Speed   (float    moveSpeed ){
        speedEnemy = moveSpeed;
     }
    private void OnTriggerEnter2D(Collider2D collision){ 
        if (collision.gameObject.CompareTag("Playerr")){
            player.GetComponent<Player>().TakeDame(damageEnter);
        }
    }
  private void OnTriggerStay2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Playerr")) {
            player.GetComponent<Player>().TakeDame(damageStay);
        }
    }

}
