using TMPro;
using UnityEngine;


public class Gun : MonoBehaviour
{
     public float rotateOffset = 180f;
    public GameObject bulletPosition;
    public GameObject bullet;
    public int bulletAmount =20;
    public GameObject textBullet;
    public GameObject Mussic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }
    // Update is called once per frame
    void Update()
    {
        //     kiem tra   text   có   còn    đạn    không  
        if (bulletAmount > 0)
        {
            textBullet.GetComponent<TextMeshProUGUI>().text = bulletAmount.ToString();
            
        }   else
        {
            textBullet.GetComponent<TextMeshProUGUI>().text = "0";

        }
        Vector3 mousePos = Input.mousePosition;
        if (mousePos.x < 0 || mousePos.x > Screen.width || mousePos.y < 0 || mousePos.y > Screen.height)
        {
            return; // Thoát khỏi hàm Update, không làm gì cả 

        }   
        //      xoay   gameObject  theo   cursor 
        Vector3 displacement =  Camera.main.ScreenToWorldPoint(Input.mousePosition)  - transform.position;
          float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
          transform.rotation = Quaternion.Euler(0, 0, angle);


        if (angle < -90 || angle > 90)
        {
            transform.localScale = new Vector3(10731.24f, -10731.24f, 10731.24f); // Lật ngược trục Y
        }
        else
        {
            transform.localScale = new Vector3(10731.24f, 10731.24f, 10731.24f); // Bình thường
        }
        //   hàm  bán  đạn  
        shoot();
        //  hàm   nạp lại   đạn 
        reloadBullet();
        //-------------------------------------------------------
    }
   


    public    void    shoot(){
            if   (Input .GetMouseButtonDown(0) &&   bulletAmount > 0  ) {
            Instantiate(bullet, bulletPosition.transform.position,   bulletPosition.transform.rotation);
            bulletAmount--;
            Mussic.GetComponent<Mussic>().PlayeshootSound();

         

        }
    }
   public  void   reloadBullet   () {
        //    kiểm  tra   chuột phải   hồi  lại đạn  
        if (Input.GetMouseButtonDown(1)   &&   bulletAmount   <=  0 ){
            bulletAmount = 20;
            Mussic.GetComponent<Mussic>().PlayeReloadSound();


        }
    }

}
