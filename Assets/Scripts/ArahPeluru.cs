using UnityEngine;

public class ArahPeluru : MonoBehaviour
{
    public float kecepatan = 5f;
    public float DestroyPeluru = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, DestroyPeluru);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, kecepatan*Time.deltaTime, 0); 
    }
}
