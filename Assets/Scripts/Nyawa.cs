using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Nyawa : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float nyawa; //float ialah class untuk menampung angka desimal
                        //waktu adalah variable yang menampung nilai dari waktu

    public int MaximumNyawa;
    //int ialah class untuk menampung angka bulat
    //MaximumWaktu adalah variable yang menampung nilai dari waktu maksimal

    // public KeyCode StartCoroutineKey;
    // //Keycode ialah class untuk menampung keycode
    // //StartCoroutineKey adalah variable yang menampung nilai dari keycode untuk memulai coroutine

    // public KeyCode StopCoroutineKey;
    // //StopCoroutineKey adalah variable yang menampung nilai dari keycode untuk menghentikan coroutine

    // public Coroutine HitungTimerCoroutine;
    // //Coroutine ialah class untuk menampung coroutine
    // //coroutine berfungsi untuk menjalankan perintah secara berurutan
    // //HitungTimerCoroutine adalah variable yang menampung nilai dari coroutine

    public Image ProgressFill;

    // Update is called once per frame
    void Start()
    {

    }

    void Update()
    {
        
    }
    public void KurangNyawa()
    {
        nyawa = MaximumNyawa --;

        ProgressFill.fillAmount = nyawa / 10f;
        if (nyawa == 0)
            {
                SceneManager.LoadScene("GameOver");
            
            }
    }
}
