using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Audio Pemain Menembak
    // Musuh sampai bawah layar
    // Peluru tabrak musuh
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource _SFXSpawnPeluru;
    public AudioSource _SFXNabrakMusuh;


    public void putarSpawnPeluru()
    {
        _SFXSpawnPeluru.Play();

    }

    public void putarNabrakMusuh()
    {
        _SFXNabrakMusuh.Play();

    }
}
