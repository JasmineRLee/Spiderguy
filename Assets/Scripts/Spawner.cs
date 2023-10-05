using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;

    [SerializeField] private GameObject entity;

    [SerializeField] private bool canSpawn = true;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn)
        {
            yield return wait;

            int rand = Random.Range(-300, 360);

            Vector3 position = new Vector3(rand, 0, 0) + transform.position;

            Instantiate(entity, position, Quaternion.identity);
        }
    }
}
