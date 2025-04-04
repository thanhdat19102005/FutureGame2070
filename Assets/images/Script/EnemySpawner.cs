using System;
using System.Collections;

using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject []   enemy;
    public GameObject[] position;
    public GameObject player;
    public GameObject image;
    public GameObject mussic;

    public float timeDistance = 4f;
    void Start()
    {
        StartCoroutine(call());
        
    }

    
    IEnumerator   call   ()     {
      
         while (true){
            yield return new WaitForSeconds(timeDistance);
            //     lấy    random   1  gameObject  trong  mang  
            GameObject ghost = enemy[UnityEngine.Random.Range(0, enemy.Length)];
            GameObject pos = position[UnityEngine.Random.Range(0, position.Length)];
              GameObject      newGhost =       Instantiate(ghost, pos.transform.position, Quaternion.identity);
            if (newGhost.name.Equals("EnergyEnemy(Clone)"))
            {
                newGhost.GetComponent<EnergyEnemy>().Player(player);
                newGhost.GetComponent<EnergyEnemy>().MussicEnergy(mussic);


            }   
           else if    ( newGhost.name.Equals("EnemyNomal(Clone)"))
            {
                newGhost.GetComponent<EnemyNomal>().Player(player);
            }
            else   if (newGhost.name.Equals("ExplosionEnemy(Clone)") )
            {
                newGhost.GetComponent<ExplosionEnemy>().Player(player);
            }
            else if (newGhost.name.Equals("HealEnemy(Clone)"))
            {
                newGhost.GetComponent<healEnemy>().Player(player);
                newGhost.GetComponent<healEnemy>().Image(image) ;

            } else      if (newGhost.name.Equals("BossEnemy(Clone)"))
            {
                newGhost.GetComponent<healEnemy>().Player(player);
            }


        }
           
              
              
    }

   
}
