using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public float spawnInterval = 0.1f;
    public Vector3 spawnPoint;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            SpawnObject();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnObject()
    {
        int randomIndex = Random.Range(0, objectsToSpawn.Length);
        var box = Instantiate(objectsToSpawn[randomIndex], spawnPoint, Quaternion.identity);
    }
}
