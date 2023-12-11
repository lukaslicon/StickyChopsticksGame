using System.Collections;
using UnityEngine;

public class RandomItemSpawn : MonoBehaviour
{
    public GameObject[] itemPrefabs; // Array of prefabs to spawn
    public Transform spawnPoint; // Specific spawn point
    public float spawnInterval = 3f; // Interval between spawns in seconds

    private void Start()
    {
        // Start spawning items
        StartCoroutine(SpawnItems());
    }

    IEnumerator SpawnItems()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            // Generate a random index for the itemPrefabs array
            int randomIndex = Random.Range(0, itemPrefabs.Length);

            // Instantiate a random prefab from the array at the specific spawn point position and rotation
            Instantiate(itemPrefabs[randomIndex], spawnPoint.position, Quaternion.identity);
        }
    }
}
