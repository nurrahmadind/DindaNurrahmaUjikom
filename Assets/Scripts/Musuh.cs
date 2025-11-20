using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Musuh : MonoBehaviour
{
    
   void Start()
    {
        Destroy(gameObject, 3f);
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
        if (collision.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
