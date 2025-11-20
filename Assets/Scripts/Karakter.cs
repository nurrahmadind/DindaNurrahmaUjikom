using UnityEngine;

public class Karakter : MonoBehaviour
{
   public Transform CubeTransform;
   public Vector2 PosisiKlik;

   public GameObject spawnPeluru;

   void Start()
    {
    
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        //geser objek ke mouse
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // CubeTransform.position = worldMousePosition;
        // CubeTransform.position = Vector2.MoveTowards (CubeTransform.position, worldMousePosition,0.05f);
        //geser object ke klik
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        //untuk menentukan posisi minimum stelah diubah menjadi posisi world
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0, 0));
        //untuk menentukan posisi maksimum stelah diubah menjadi posisi world

        worldMousePosition.x = Mathf.Clamp(worldMousePosition.x, minimum.x, maximum.x);
        //untuk menentukan batas x dari posisi mouse
        worldMousePosition.y = -4.5f;

        CubeTransform.position = worldMousePosition;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           //ini harusnya nanti spawn object
        }
        // CubeTransform.position = Vector2.MoveTowards (CubeTransform.position, PosisiKlik,0.1f);
        //fungsi ini berguna untuk menggeser objek ke posisi yang telah ditentukan
        //0.1f adalah kecepatan gerak
        //cubetransform.position adalah posisi objek yang akan digeser
        //posisiklik adalah posisi yang dituju

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(spawnPeluru, new Vector3(worldMousePosition.x, -4.5f, 0), Quaternion.identity);
        }
        
    }

}
