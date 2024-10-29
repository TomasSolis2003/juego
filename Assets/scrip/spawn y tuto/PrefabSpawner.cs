using System.Collections;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn; // Asigna tu prefab aquí
    public float spawnInterval = 180f; // Intervalo de 3 minutos en segundos

    private void Start()
    {
        StartCoroutine(SpawnPrefab());
    }

    private IEnumerator SpawnPrefab()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval); // Espera el intervalo

            // Generar una posición aleatoria o definida (puedes ajustar esto)
            Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), 1, Random.Range(-5f, 5f));
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity); // Crea el prefab
        }
    }
}
