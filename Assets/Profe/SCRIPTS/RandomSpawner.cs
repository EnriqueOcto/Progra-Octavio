using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject enemigo;
    public float wait;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    void Update()
    {
        wait = Random.Range(5, 10);
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(wait);
        while (true) 
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-39, 42), 1, Random.Range(-10, 85));
            Instantiate(enemigo, randomSpawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(wait);
        }
    }

}
