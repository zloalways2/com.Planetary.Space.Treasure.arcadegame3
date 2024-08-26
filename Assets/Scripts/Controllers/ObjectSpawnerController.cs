using UnityEngine;

namespace Controllers
{
    public class ObjectSpawnerController : MonoBehaviour
    {
        [SerializeField] private GameObject _coinPrefab;
        [SerializeField] private GameObject[] _spherePrefab;
        private float spawnInterval = 0.1f; 
        private int coinSpawnChance = 80; 

        private void Start()
        {
            InvokeRepeating("SpawnObject", 0f, spawnInterval);
        }

        private void SpawnObject()
        {
            int randomValue = Random.Range(0, 100);

            if (randomValue < coinSpawnChance)
            {
                SpawnCoin();
            }
            else
            {
                SpawnSphere();
            }
        }

        private void SpawnCoin()
        {
            var coin = Instantiate(_coinPrefab, GetRandomSpawnPosition(), Quaternion.identity);
            coin.transform.parent = transform.parent;
        }

        private void SpawnSphere()
        {
            var sphere = Instantiate(_spherePrefab[Random.Range(0,_spherePrefab.Length)], GetRandomSpawnPosition(), Quaternion.identity);
            sphere.transform.parent = transform.parent;
        }

        private Vector3 GetRandomSpawnPosition()
        {
            float x = Random.Range(-8f, 8f);
            float y = Random.Range(-4f, 4f);
            return new Vector3(x, y, 0);
        }
    }
}