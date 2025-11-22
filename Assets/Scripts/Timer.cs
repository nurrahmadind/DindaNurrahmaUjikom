using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float waktu; //float ialah class untuk menampung angka desimal
    //waktu adalah variable yang menampung nilai dari waktu
    
    public int MaximumWaktu;
    //int ialah class untuk menampung angka bulat
    //MaximumWaktu adalah variable yang menampung nilai dari waktu maksimal
      public bool WaktuBerjalan=true;
    //bool berguna untuk menampung nilai true atau false
    //WaktuBerjalan adalah variable yang menampung nilai dari waktu berjalan
    //bool digunakan untuk menentukan apakah waktu berjalan atau tidak

    // public KeyCode StartCoroutineKey;
    // //Keycode ialah class untuk menampung keycode
    // //StartCoroutineKey adalah variable yang menampung nilai dari keycode untuk memulai coroutine

    // public KeyCode StopCoroutineKey;
    // //StopCoroutineKey adalah variable yang menampung nilai dari keycode untuk menghentikan coroutine

    public Coroutine HitungTimerCoroutine;
    // //Coroutine ialah class untuk menampung coroutine
    // //coroutine berfungsi untuk menjalankan perintah secara berurutan
    // //HitungTimerCoroutine adalah variable yang menampung nilai dari coroutine

    public Image ProgressFill;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(HitungTimer());       
    }

   void Update()
    {
       
    }
    IEnumerator HitungTimer()
    {
        while (WaktuBerjalan == true && waktu < MaximumWaktu)
        // fungsi pada baris ini berfungsi untuk menampilkan timer
        //waktu berjalan adalah boolean yang menentukan apakah timer berjalan atau tidak
        //waktu < MaximumWaktu adalah untuk menentukan apakah waktu sudah mencapai batas maksimal atau belum
        //waktu adalah variabel yang menentukan berapa detik yang sudah berjalan
        //MaximumWaktu adalah variabel yang menentukan berapa detik yang akan berjalan
        {
        waktu ++; //waktu akan bertambah setiap detik
        ProgressFill.fillAmount = waktu /MaximumWaktu;
        
        yield return new WaitForSeconds(1);
        // Debug.Log (WaktuBerjalan):   
         if (waktu == MaximumWaktu)
        
            {
                SceneManager.LoadScene("GameOver");
            
            }
        }
    }
}
