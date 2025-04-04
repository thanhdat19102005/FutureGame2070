using UnityEngine;
using UnityEngine.Audio;

public class Mussic : MonoBehaviour
{
    public GameObject AudioSource;
    public AudioClip shootClip;
    public AudioClip reloadClip;
    public AudioClip enegyClip;
    public AudioClip boss;

    public int ttt;

    public void Start()
    {
       
    }
    public void Update()
    {
       
    }

    public  void   PlayeshootSound    ()   {
         if  (AudioSource!=   null)   
        AudioSource.GetComponent<AudioSource>().PlayOneShot(shootClip);

    }


    
    public void PlayeReloadSound()  {
        if (AudioSource != null)
            AudioSource.GetComponent<AudioSource>().PlayOneShot(reloadClip);

    }
    public void EnemySound() {
        if (AudioSource != null)
            AudioSource.GetComponent<AudioSource>().PlayOneShot(enegyClip);

    }
    public    void    BossSound     ()
    {
        if (AudioSource != null)
            AudioSource.GetComponent<AudioSource>().PlayOneShot(boss);
    }
    public void Stop()
    {
        if (AudioSource != null)
            AudioSource.GetComponent <AudioSource>().Stop(); // Dừng âm thanh từ Play()
       

    }
}
