using UnityEngine;

public class ArahPeluru : MonoBehaviour
{
    public float kecepatan = 5f;
    public float DestroyPeluru = 2f;
    public Score valScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, DestroyPeluru);
        // GameObject _gameObject = GameObject.FindGameObjectWithTag("Score");
        // score = gameObject.GetComponent<Score>();

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, kecepatan*Time.deltaTime, 0); 
        // score.tambahScore();
        // score.UpdateScore();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.CompareTag("Musuh"))
        {
            Debug.Log ("Nabrak Musuh");
            valScore.TambahScore();
            valScore.UpdateScore();
            Destroy(gameObject);

        }
    }
}
