using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float Waktu;
    public Score skor;

    public float MaximumWaktu;

    public bool WaktuBerjalan = true;

    public Coroutine HitungTimerCoroutine;

    public Image ProgressFill;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(HitungTimer());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator HitungTimer()
    {
        while (WaktuBerjalan == true && Waktu < MaximumWaktu)
        {
            // Waktu = Waktu + 1;
            // TextTimer.text = Waktu.ToString();
            Waktu++;
            ProgressFill.fillAmount = Waktu / MaximumWaktu;
            yield return new WaitForSeconds(1);
            if (Waktu == MaximumWaktu)
            {
                WaktuBerjalan = false;
                PlayerPrefs.SetInt("SkorAkhir", skor.ScoreValue);
                PlayerPrefs.Save();
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
