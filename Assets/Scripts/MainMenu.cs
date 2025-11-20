using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TMP_Text text;
    
     public void GamePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void ExitGame()
    {
        Debug.Log("Keluar dari Game");
        
        // Perintah standar untuk keluar dari aplikasi. 
        // Ini hanya akan bekerja saat game sudah di-build (file .exe).
        Application.Quit();

        // Optional: Baris di bawah ini hanya untuk membuat tombol Quit berfungsi
        // saat Anda mengujinya di Unity Editor. Hapus baris ini saat di-build.
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
