using System;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
     //   lấy  trực     tiếp    từ      Asset 
    public Texture2D cursorNomal;
    public Texture2D cursorShoot;
    public Texture2D cursorReload;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Cursor.SetCursor(cursorNomal, Vector2.zero, CursorMode.Auto);
        cursorNomal = ResizeTexture(cursorNomal, 64,  64);
        Cursor.SetCursor(cursorNomal, new Vector2(32 , 32 ), CursorMode.Auto);
        

    }

    public     Texture2D ResizeTexture(Texture2D texture, int width, int height)  {
        RenderTexture rt = new RenderTexture(width, height, 32);
        RenderTexture.active = rt;
        Graphics.Blit(texture, rt);

        Texture2D result = new Texture2D(width, height, TextureFormat.ARGB32, false);
        result.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        result.Apply();

        RenderTexture.active = null;
        rt.Release();

        return result;
    }

    // Update is called once per frame
    void Update()
    {
         if   (Input  .GetMouseButtonDown(0)){
               cursorShoot = ResizeTexture(cursorShoot, 64, 64);
            Cursor.SetCursor(cursorShoot, new Vector2(32, 32), CursorMode.Auto);
        } else  if     (Input.GetMouseButtonUp(0))  
        {
            cursorNomal = ResizeTexture(cursorNomal, 64, 64);
            Cursor.SetCursor(cursorNomal, new Vector2(32, 32), CursorMode.Auto);
        }
      if  (  Input .GetMouseButtonDown(1))
        {
            cursorReload = ResizeTexture(cursorReload, 64, 64);
            Cursor.SetCursor(cursorReload, new Vector2(32, 32), CursorMode.Auto);
        }
      else  if (Input.GetMouseButtonUp(1))
        {
            cursorNomal = ResizeTexture(cursorNomal, 64, 64);
            Cursor.SetCursor(cursorNomal, new Vector2(32, 32), CursorMode.Auto);
        } 


    }
}
