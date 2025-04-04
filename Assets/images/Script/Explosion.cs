using UnityEngine;

public class Explosion : MonoBehaviour
{
    
    public float damage = 25f;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision){


        if (collision.gameObject.CompareTag("Playerr")) {
           collision.gameObject.GetComponent   <Player>   ()  .TakeDame   (damage) ;
             
        }  
         if  (collision  .gameObject  .CompareTag   ("Explosion"))
        {
              if    (collision   .gameObject   !=   null   ) 
            collision.gameObject.GetComponent<ExplosionEnemy>().TakeDame(damage);
            
        }      
       
    }
    public void DestroyGamObject()
    {
           if  (gameObject  !=   null) 
        Destroy(gameObject);
        
    }



}
