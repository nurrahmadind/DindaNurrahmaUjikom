using System.Collections;
using UnityEngine;
// using UnityEngine.Rendering.Universal;

public class MusuhSpawner : MonoBehaviour
{
    public GameObject musuhEnemy1;
    public GameObject musuhEnemy2;
    public GameObject musuhEnemy3;

    public bool sedangSpawn = true;
    public float spawnRate = 2f;

    
    void Start()
    {
        StartCoroutine(spawnEnemy1());
        StartCoroutine(spawnEnemy2());
    }
    void Update()
    {
        
    }

    IEnumerator spawnEnemy1()
    {
        while (sedangSpawn==true)
        {
            Instantiate(musuhEnemy1, new Vector3(Random.Range(-5,5), 5,0), Quaternion.identity);
            
            yield return new WaitForSeconds(spawnRate);}
    }
    IEnumerator spawnEnemy2()
    {
        while (sedangSpawn==true)
        {
            Instantiate(musuhEnemy2, new Vector3(Random.Range(-5,5), 5,0), Quaternion.identity);
            
            yield return new WaitForSeconds(spawnRate);}
    }
}