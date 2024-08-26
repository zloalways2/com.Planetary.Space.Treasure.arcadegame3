using UnityEngine;

public class FallingObjectController : MonoBehaviour
{
    private float _fallSpeed = 3f;
    private float _spawnXRange = 2.5f;

    void Start()
    {
        float randomX = Random.Range(-_spawnXRange, _spawnXRange);
        transform.position = new Vector3(randomX, Camera.main.orthographicSize + 1, 0);
    }

    void Update()
    {
        transform.Translate(Vector3.down * _fallSpeed * Time.deltaTime);
        
        if (transform.position.y < -Camera.main.orthographicSize - 1)
        {
            Destroy(gameObject);
        }
    }
}