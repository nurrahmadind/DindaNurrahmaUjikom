// using TMPro;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class Score : MonoBehaviour
// {
//     public TMP_Text scoreText;
//     // public AudioObject audioObject;
//     public int score;
//     public int targetScore = 100;
//     public int highScore;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         score = 0;
     

//     public void tambahScore()
//     {
//         score += 5;
//     }

//     public void kurangScore()
//     {

//     }


//     // Update is called once per frame
//     void Update()
//     {
//         // if(Input.GetKeyDown(KeyCode.Mouse0))
//         // {
//         //     Vector2 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);

//         //     Collider2D objectTerdeteksi = Physics2D.OverlapPoint(posisiKlik);

//         //     // GameObject objectHapus = objectTerdeteksi.gameObject;

//         //     if (objectTerdeteksi != null)
//         //     {
//         //         if(objectTerdeteksi.CompareTag("daurulang"))
//         //         {
//         //             GameObject objectHapus = objectTerdeteksi.gameObject;
//         //             Debug.Log("sampah daur ulang diklik");
//         //             // Debug.Log("Object dihapus: " + objectHapus.name);
//         //             Destroy(objectHapus);
//         //             tambahScore();
//         //             audioObject.putarSFXDaurUlang();
//         //         }
//         //         else if(objectTerdeteksi.CompareTag("tdkdaurulang"))
//         //         {
//         //             GameObject objectHapus = objectTerdeteksi.gameObject;
//         //             Debug.Log("sampah tidak daur ulang diklik");
//         //             // Debug.Log("Object dihapus: " + objectHapus.name);
//         //             Destroy(objectHapus);
//         //             kurangScore();
//         //             audioObject.putarSFXTdkDaurUlang();
//         //         }
//         //         else
//         //         {
//         //             GameObject objectHapus = objectTerdeteksi.gameObject;
//         //             Debug.Log("racun diklik");
//         //             // Debug.Log("Object dihapus: " + objectHapus.name);
//         //             Destroy(objectHapus);
//         //             //score = 0;
//         //             audioObject.putarSFXRacun();
//         //             score = 0;
//         //             PlayerPrefs.SetInt("lastscore", score);
//         //             SceneManager.LoadScene("GameOver");
//         //         }
//         //         scoreText.text = "Score: " + score.ToString();
//         //     }
//         }
//     }
// }
