using System.Collections;
using UnityEngine;
// using UnityEngine.Rendering.Universal;

public class MusuhSpawner : MonoBehaviour
{
    public GameObject musuhPrefab;

    public bool sedangSpawn = true;
    public float spawnRate = 2f;

    
    void Start()
    {
        StartCoroutine(MunculMusuh());
    }
    void Update()
    {
        
    }

    IEnumerator MunculMusuh()
    {
        while (sedangSpawn==true)
        {
            Instantiate(musuhPrefab, new Vector3(Random.Range(-5,5), 5,0), Quaternion.identity);
            
            yield return new WaitForSeconds(spawnRate);}
    }
}