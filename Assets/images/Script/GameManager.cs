using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameManager;
    public int currentPoint = 0;
    public int maxPoint = 3;
   

    public GameObject Boss;
    public int loop = 1;

    public GameObject playUI;
    public GameObject playQuit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoint == maxPoint)
        {
            if (loop == 1)  {
               if (Boss != null) {
                    Boss.SetActive(true);
                }
                loop = 2;
            }
        }
    }

     public void addPoint()  {
        currentPoint += 1;
       
        

                      
    }

     public void PlayGame()
    {
        SceneManager.LoadScene("play");
        
    }

    public void Home()
    {
        SceneManager.LoadScene("start");
    }
    public void Quit()
    {
          Application  .Quit();
    }
}
