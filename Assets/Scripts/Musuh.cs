using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Musuh : MonoBehaviour
{
    public Nyawa nyawa;//karena berkomunikasi dengan nyawa jika musuh menyentuh bagian bawah nyawa berkurang -1
   void Start()
    {
        Destroy(gameObject, 3f);
        GameObject _gameObject = GameObject.FindGameObjectWithTag("Nyawa");
        nyawa = _gameObject.GetComponent<Nyawa>();
    }
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Peluru"))
        {
            Destroy(gameObject);
            //Destroy(collision.gameObject);
        }
        if (collision.collider.CompareTag("Lantai"))
        {
            nyawa.KurangNyawa();
            Debug.Log ("nyawa berkurang");
            Destroy(gameObject);
        }
    }

}
