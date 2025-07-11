using System.Collections;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform spawnArea;
    public float spawnInterval = 1.5f;

    void Start()
    {
        StartCoroutine(SpawnRandomPrefabs());
    }

    IEnumerator SpawnRandomPrefabs()
    {
        while (true)
        {
            SpawnPrefab();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnPrefab()
    {
        int index = Random.Range(0, prefabs.Length);
        Vector3 randomPos = new Vector3(Random.Range(-5f, 5f), 1f, Random.Range(-5f, 5f));
        GameObject spawned = Instantiate(prefabs[index], randomPos, Quaternion.identity);
        Destroy(spawned, 2f); // Automatically destroy after 2 seconds
    }
}
