using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TMP_Text text;
    public class simpanScore : MonoBehaviour
    {
        public TMP_Text teksSkor;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            teksSkor.text = "Score: " + PlayerPrefs.GetInt("ScoreValue").ToString();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
    public void Retry()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
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
}
